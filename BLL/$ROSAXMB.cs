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

        public Staff Login (string email, string password)
        {
            throw new NotImplementedException();
        }


        public bool IsExistedStaffByEmailOrPhone (string email, string phone)
        {
            Staff existedStaff = _staffRepository.GetStaffByEmailOrPhone(email, phone);
            return existedStaff != null;
        }

     
        public Staff RegisterStoreOwner (RegisterStoreDto dto, Store store)
        {

            Role ownerRole = _roleService.CreateStoreOwnerRole(store);


            Staff owner = new Staff()
            {
                Email = dto.OwnerEmail,
                Name = dto.OwnerName,
                Password = dto.OwnerPassword,
                Phone = dto.OwnerPhone,
              //  Role = ownerRole,
                Workplace = store,
            };

            return owner;
        }

    }
}
