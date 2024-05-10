using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.BLL.Interfaces
{
    public interface IStaffService
    {
        Staff Login(string username, string password);
        Staff SaveStaff(NewStaffDto dto);
        bool IsExistedStaffByEmailOrPhone(string email, string phone);
        bool IsExistedStaffByPhone(string phone);
        bool IsExistedStaffByEmail(string email);
        bool IsExistedStaffById(long staffId);
        Staff RegisterStoreOwner(NewStoreDto dto, Store newStore);
        List<Staff> GetAllStaffByStoreId(long storeId);
        List<Staff> SearchStaff(string keyword);
        Staff GetStaffById(long staffId);
        Staff UpdateStaff(Staff updateStaff);

        Staff UpdatePassword(ChangePasswordDto dto);
    }
}
