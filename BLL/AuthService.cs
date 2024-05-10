using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.BLL
{
    public class AuthService : IAuthService
    {

        private static Staff _authenticatedStaff;
        private static Store _store;

        public Staff GetAuthenticatedStaff()
        {
           if (_authenticatedStaff == null)
           {
                throw new Exception("Người dùng chưa đăng nhập");
           }
            return _authenticatedStaff;
        }

        public Store GetStoreInfo()
        {
            if (_store == null)
            {
                throw new Exception("Người dùng chưa đăng nhập");
            }
            return _store;
        }

        public void SetAuthenticatedStaff(Staff staff)
        {
            _authenticatedStaff = staff;
        }

        public void SetStoreInfo(Store store)
        {
            _store = store;
        }
    }
}
