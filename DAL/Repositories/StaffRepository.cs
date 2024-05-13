using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.DAL.Repositories
{
    public class StaffRepository : IStaffRepository
    {

        private readonly AppDBContext _db;

        public Staff GetStaffById(long staffId)
        {
            return _db.Staff.FirstOrDefault(s => s.Id.Equals(staffId));
        }
        public StaffRepository (IDataAccessLayer dbAccessLayer)
        {
            _db = dbAccessLayer.GetContext();
        }

        public Staff GetStaffByEmail(string email)
        {
            return _db.Staff
                .Include(s => s.Workplace)
                .Include(s => s.Role)
                .FirstOrDefault(staff => staff.Email.Equals(email));
        }

        public Staff GetStaffByPhone(string phone)
        {
            return _db.Staff.FirstOrDefault(staff => staff.Phone.Equals(phone));
        }

        public Staff SaveStaff (Staff staff)
        {
            Staff newStaff = _db.Staff.Add(staff);
            _db.SaveChanges();
            return newStaff;
        }

        public Staff GetStaffByEmailOrPhone(string email, string phone)
        {
            return _db.Staff
                .Include(s => s.Role)
                .Include(s => s.Workplace)
                .FirstOrDefault(staff => staff.Phone.Equals(phone) || staff.Email.Equals(email));
        }
    

        public List<Staff> GetAllStaffByStoreId(long storeId)
        {
            return _db.Staff
                .Include(s => s.Role)
                .Where(s => s.WorkplaceId.Equals(storeId))
                .ToList();
        }

        public List<Staff> GetAllStaffContainsKeyword(string keyword)
        {
            keyword = keyword.ToLower();
            return _db.Staff.Where(s =>
                s.Name.ToLower().Contains(keyword) ||
                s.Email.ToLower().Contains(keyword) ||
                s.Phone.ToLower().Contains(keyword)
            )
                .ToList();
        }

        public Staff UpdateStaff(Staff staff)
        {


            if (!IsExistStaffbyId(staff.Id))
            {
                throw new Exception("Không tìm thấy nhân viên " + staff.Id + " ");
            }

            Staff updatedStaff = _db.Staff.Attach(staff);

            _db.Entry(staff).State = EntityState.Modified;

            _db.SaveChanges();
            return updatedStaff;
        }


        private bool IsExistStaffbyId (long staffId)
        {
            return _db.Staff.FirstOrDefault(s => s.Id.Equals(staffId)) != null;
        }
    }
}
