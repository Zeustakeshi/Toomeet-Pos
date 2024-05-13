using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DAL.Repositories;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Roles;

namespace Toomeet_Pos.BLL
{
    public class RoleService : IRoleService
    {

        private readonly IRoleRepository _roleRepository;


        public RoleService (IRoleRepository roleRepository) {
            _roleRepository = roleRepository;
        }


        public Role CreateRole (Store store, Role role)
        {
            role.Store = store;
            role.StoreId = store.Id;
            return _roleRepository.SaveRole(role);
        }

        public Role CreateStoreOwnerRole(Store store)
        {
            Role ownerRole = new Role() { 
                Name = "Chủ cửa hàng",
                Description = "Chủ cửa hàng có quyền cao nhất trong toàn bộ cửa hàng",
                Store = store
            };
            GrantFullPermission(ownerRole);

            return ownerRole;
        }

 

        private void GrantFullPermission(Role role)
        {
            GrantFullInvetoryInspectionPermission(role);
            GrantFullManagePermission(role);
            GrantFullOrderPermission(role);
            GrantFullCustomerPermission(role);
            GrantFullProductPermission(role);
            GrantFullStaffPermission(role);
        }

        private void GrantFullInvetoryInspectionPermission (Role role)
        {
            role.InvetoryInspection =   new RoleInvetoryInspection()
            {
                BalanceInventory = true,
                DeleteInventoryCount = true,
                CreateInventoryCount = true,
                EditInventoryCount = true,
                ExportInventoryCountFile = true,
                ImportInventoryCountFile = true,
                ViewInVentoryCount = true,
            };
        }

        private void GrantFullStaffPermission (Role role)
        {
            role.Staff = new RoleStaff()
            {
                CreateStaff = true,
                EditStaff = true,
                ExportStaffFile = true,
                ImportStaffFile = true,
                RemoveStaff = true,
                ViewAllStaff = true
            };
        }

        private void GrantFullManagePermission(Role role)
        {
            role.Manage = new RoleManage()
            {
                EditPrintingTemplate = true,
                EditStoreInformation = true,
                GeneralConfiguration = true,
                OrderProcessManagement = true,
                PermissionManagement = true,
                ViewActiveLog = true,
                PaymentManagement = true,
            };
        }

        private void GrantFullOrderPermission(Role role)
        {
            role.Order = new RoleOrder()
            {
                ApproveOrder = true,
                CreateOrder = true,
                CancelOrder = true,
                EditOrder = true,
                ImportOrderFile = true,
                ExportOrderFile = true,
                ViewAllOrder = true,
                ViewAssignedOrder = true
            };
        }

        private void GrantFullCustomerPermission(Role role)
        {
            role.Customer = new RoleCustomer()
            {
                CreateCustomer = true,
                EditCustomer = true,
                ExportCustomerFile = true,
                ImportCustomerFile = true,
                ViewAllCustomers = true,
                ViewAssignedCustomers = true,
                DeleteCustomer = true
            };
        }

        private void GrantFullProductPermission(Role role)
        {
            role.Product = new RoleProduct()
            {
                DeleteProduct = true,
                EditProduct = true,
                ViewProduct = true,
                ExportProductFile = true,
                ImportProductFile = true,
                CreateProduct = true
            };

        }

        public Role GetRoleById(long roleId)
        {
            return _roleRepository.GetRoleById(roleId);
        }

        public List<Role> GetAllRoleByStoreId (long storeId) {
            return _roleRepository.GetAllRoleByStoreId(storeId);
        }

        public bool CanGeneralConfiguration(Staff staff)
        {
            Role role = _roleRepository.GetManageRoleByRoleId(staff.Role.Id);
            return role.Manage.GeneralConfiguration;
        }

        public bool CanEditStoreInfo (Staff staff)
        {
            Role role = _roleRepository.GetManageRoleByRoleId(staff.Role.Id);
            return role.Manage.EditStoreInformation;
        }

        public bool CanCreateStaff(Staff staff)
        {
            Role role = _roleRepository.GetStaffRoleByRoleId(staff.Role.Id);
            return role.Staff.CreateStaff;
        }

        public bool CanViewAllStaff(Staff staff)
        {
            Role role = _roleRepository.GetStaffRoleByRoleId(staff.Role.Id);
            return role.Staff.ViewAllStaff;
        }

        public bool CanEditStaff(Staff staff)
        {
            Role role = _roleRepository.GetStaffRoleByRoleId(staff.Role.Id);
            return role.Staff.EditStaff;
        }
         
        public bool CanManageRole (Staff staff)
        {
            Role role = _roleRepository.GetManageRoleByRoleId(staff.Role.Id);
            return role.Manage.PermissionManagement;
        }

        public bool CanCreateProduct(Staff staff)
        {
            Role role = _roleRepository.GetProductRoleByRoleId(staff.Role.Id);
            return role.Product.CreateProduct;
        }

        public bool CanEditProduct (Staff staff)
        {
            Role role = _roleRepository.GetProductRoleByRoleId(staff.Role.Id);
            return role.Product.EditProduct;
        }

        public bool CanViewProduct(Staff staff)
        {
            Role role = _roleRepository.GetProductRoleByRoleId(staff.Role.Id);
            return role.Product.ViewProduct;
        }
    }
}
