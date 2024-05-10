using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.DAL.Repositories
{
    public interface IRoleRepository
    {
        Role SaveRole(Role role);
        Role GetRoleById(long roleId);
        List<Role> GetAllRoleByStoreId(long storeId);

        /* Store*/
        Role GetManageRoleByRoleId(long roleId);

        /* Staff*/

        Role GetStaffRoleByRoleId(long roleId);

        /* Product*/

        Role GetProductRoleByRoleId(long roleId);


    }
}
