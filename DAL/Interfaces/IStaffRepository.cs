using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.DAL.Interfaces
{
    public interface IStaffRepository
    {
        Staff GetStaffByEmail(string email);
        Staff GetStaffByPhone(string phone);
        Staff GetStaffById(long staffId);
        Staff GetStaffByEmailOrPhone(string email, string phone);
        Staff SaveStaff(Staff staff);
        List<Staff> GetAllStaffByStoreId(long storeId);
        List<Staff> GetAllStaffContainsKeyword(string keyword);

        Staff UpdateStaff(Staff staff);
    }
}
