using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.DAL.Interfaces
{
    public interface IRoleService
    {
        Role CreateStoreOwnerRole(Store store);

        Role CreateRole(Store store, Role role);

        Role GetRoleById(long roleId);
        List<Role> GetAllRoleByStoreId(long storeId);

        /* STORE CONFIGURATION */

        bool CanGeneralConfiguration(Staff staff);

        bool CanEditStoreInfo(Staff staff);

        /* STAFF */

        bool CanCreateStaff(Staff staff);

        bool CanViewAllStaff(Staff staff);

        bool CanEditStaff(Staff staff);

        /* ROLE */

        bool CanManageRole(Staff staff);

        /* Product */
        bool CanCreateProduct(Staff staff);

        bool CanViewProduct(Staff staff);

        bool CanEditProduct(Staff staff);

    }
}
