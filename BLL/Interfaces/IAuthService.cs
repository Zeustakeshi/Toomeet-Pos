using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.BLL.Interfaces
{
    public interface IAuthService
    {
        Staff GetAuthenticatedStaff();
        Store GetStoreInfo();
        void SetAuthenticatedStaff(Staff staff);
        void SetStoreInfo(Store store);
    }
}
