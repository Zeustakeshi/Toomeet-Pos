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

    public class RoleRepository : IRoleRepository
    {
        private readonly AppDBContext _db;

        public RoleRepository(IDataAccessLayer dbAccessLayer)
        {
            _db = dbAccessLayer.GetContext();
        }

     

        public Role SaveRole(Role role)
        {
            Role newRole =  _db.Role.Add(role);
            _db.SaveChanges();
            return newRole;
        }


        public Role GetRoleById(long roleId)
        {
            return _db.Role
                .Include(r => r.Manage)
                .Include(r => r.InvetoryInspection)
                .Include(r => r.Order)
                .Include(r => r.Customer)
                .Include(r => r.Product)
                .FirstOrDefault(r => r.Id.Equals(roleId));
        }

        public List<Role> GetAllRoleByStoreId (long storeId)
        {
            return _db.Role
                .Where(r => r.Store.Id.Equals(storeId))
                .ToList();
        }

        public Role GetManageRoleByRoleId(long roleId)
        {
            return _db.Role
               .Include(r => r.Manage)
               .FirstOrDefault(r => r.Id.Equals(roleId));
        }

        public Role GetStaffRoleByRoleId(long roleId)
        {
            return _db.Role
                 .Include(r => r.Staff)
                 .FirstOrDefault(r => r.Id.Equals(roleId));
        }

        public Role GetProductRoleByRoleId(long roleId)
        {
            return _db.Role
              .Include(r => r.Product)
              .FirstOrDefault(r => r.Id.Equals(roleId));
        }
    }
}
