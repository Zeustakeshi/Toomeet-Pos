using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.BLL
{
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IRoleService _roleService;
            
        public StaffService (
            IStaffRepository staffRepository,
            IRoleService roleService
        )
        {
            _roleService = roleService;
            _staffRepository = staffRepository;
        }

        public Staff GetStaffById (long staffId)
        {
            return _staffRepository.GetStaffById(staffId);
        }

        public Staff Login (string username, string password)
        {
            Staff staff = _staffRepository.GetStaffByEmailOrPhone (email: username, phone: username);

            if (staff == null) throw new Exception("Tài khoản hoặc mật khẩu không hợp lệ");


            if (!VerifyPassword(
                hashPassword : staff.Password,
                plainPassword: password
            ))
            {
                throw new Exception("Tài khoản hoặc mật khẩu không hợp lệ");
            }

            Role role = _roleService.GetRoleById(staff.Role.Id);
            staff.Role = role;
            return staff;
        }


        public bool IsExistedStaffByEmailOrPhone (string email, string phone)
        {
            Staff existedStaff = _staffRepository.GetStaffByEmailOrPhone(email, phone);
            return existedStaff != null;
        }

     
        public Staff RegisterStoreOwner (NewStoreDto dto, Store store)
        {

            Role ownerRole = _roleService.CreateStoreOwnerRole(store);


            Staff owner = new Staff()
            {
                Name = dto.OwnerName,
                Password = HashPassword(dto.OwnerPassword),
                Phone = dto.OwnerPhone,
                Role = ownerRole,
                Workplace = store,
                Status = StaffStatus.WORKING,
                Gender = StaffGender.MALE,
                Birthday = new DateTime(2000,1, 1)
            };

            return owner;
        }

        public List<Staff> GetAllStaffByStoreId (long storeId)
        {
            return _staffRepository.GetAllStaffByStoreId(storeId);
        }

        public Staff SaveStaff(NewStaffDto dto)
        {
            Staff newStaff = dto.Staff;

            newStaff.Workplace = dto.Store;
            newStaff.WorkplaceId = dto.Store.Id;
            newStaff.Role = dto.Role;
            newStaff.Password = HashPassword(newStaff.Password);

            return _staffRepository.SaveStaff(newStaff);
        }


        public List<Staff> SearchStaff(string keyword)
        {
            return _staffRepository.GetAllStaffContainsKeyword(keyword);
        }

        public bool IsExistedStaffByPhone (string phone)
        {
            return _staffRepository.GetStaffByPhone(phone) != null;
        }


        private string HashPassword (string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt());
        }

        private bool VerifyPassword (string hashPassword, string plainPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, hashPassword);
        }


        public bool IsExistedStaffByEmail (string email)
        {
            return _staffRepository.GetStaffByEmail(email) != null;
        }

        public bool IsExistedStaffById(long staffId)
        {
            return _staffRepository.GetStaffById(staffId) != null;
        }

        public Staff UpdateStaff (Staff updateStaff )
        {
            Staff staff = GetStaffById(updateStaff.Id);

            if (staff == null)
            {
                throw new Exception("Không tìm thấy người dùng " + updateStaff.Id);
            }

            if (
              staff.Phone != null &&
              updateStaff.Phone != null &&  
              !staff.Phone.Trim().Equals(updateStaff.Phone.Trim()) &&
              IsExistedStaffByPhone(updateStaff.Phone.Trim())
            )
            {
                throw new Exception("Số điện thoại đã được sử dụng");
            }


            if (staff.Email != null && 
                updateStaff.Email != null && 
                updateStaff.Email.Trim().Length > 0 && 
                !staff.Email.Trim().Equals(updateStaff.Email.Trim()) &&
                IsExistedStaffByEmail(updateStaff.Email.Trim())
            ) {
                throw new Exception("Email đã được sử dụng");
            }

            return _staffRepository.UpdateStaff(updateStaff);
        }

        public Staff UpdatePassword(ChangePasswordDto dto)
        {

            Staff staff = _staffRepository.GetStaffById(dto.StaffId);

            if (staff == null)
            {
                throw new Exception("Không tìm thấy nhân viên này " + dto.StaffId);
            }

            if (!VerifyPassword(staff.Password, dto.CurrentPassword))
            {
                throw new Exception("Sai mật khẩu cũ");
            }

            if (VerifyPassword(staff.Password, dto.NewPassword))
            {
                throw new Exception("Mật khẩu không được trùng với mật khẩu cũ");
            }


            staff.Password = HashPassword(dto.NewPassword);

            return _staffRepository.UpdateStaff(staff);
        }
    }
}
