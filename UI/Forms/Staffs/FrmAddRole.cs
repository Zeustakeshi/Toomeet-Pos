using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites.Roles;
using Toomeet_Pos.Entites;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.UI.UC;
using Toomeet_Pos.UI.Validations;
using Guna.UI2.WinForms;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmAddRole : Form
    {


        private readonly Store _store;
        private readonly IRoleService _roleService;
        private readonly IAuthService _authService;
        private readonly IRoleValidate _roleValidate;

        private RoleManage _roleManage;
        private RoleCustomer _roleCustomer;
        private RoleStaff _roleStaff;
        private RoleOrder _roleOrder;
        private RoleProduct _roleProduct;
        private RoleInvetoryInspection _roleInvetoryInspection;

        public FrmAddRole()
        {
            InitializeComponent();

            _roleService = Program.GetService<IRoleService>();
            _authService = Program.GetService<IAuthService>();
            _authService = Program.GetService<IAuthService>();
            _roleValidate = Program.GetService<IRoleValidate>();

            _store = _authService.GetStoreInfo();

            _roleManage = new RoleManage();
            _roleCustomer = new RoleCustomer();
            _roleStaff = new RoleStaff();
            _roleOrder = new RoleOrder();
            _roleProduct = new RoleProduct();
            _roleInvetoryInspection = new RoleInvetoryInspection();

        }

        private void FrmAddRole_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            string roleName = txtRoleName.Value;
            ValidateResult validateRoleName = _roleValidate.IsValidRoleName(roleName);

            if (validateRoleName.IsError)
            {
                txtRoleName.ErrorMessage = validateRoleName.ErrorMessage;
                return;
            }


            string roleDesc = txtRoleDesc.Value;
            ValidateResult validateRoleDesc = _roleValidate.IsValidRoleDescription(roleDesc);

            if (validateRoleDesc.IsError)
            {
                txtRoleDesc.ErrorMessage = validateRoleDesc.ErrorMessage;
                return;
            }

            btnAddRole.Enabled = false;

            try
            {
                Role role = new Role()
                {
                    Name = roleName,
                    Description = roleDesc,
                    Manage = _roleManage,
                    Customer = _roleCustomer,
                    Staff = _roleStaff,
                    Product = _roleProduct,
                    Order = _roleOrder,
                    InvetoryInspection = _roleInvetoryInspection
                };

                _roleService.CreateRole(_store, role);

                MessageBox.Show("Đã thêm vai trò " + role.Name + " vào cửa hàng của bạn", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Thêm vai trò thất bại: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnAddRole.Enabled = true;

        }


        private void txtRoleName_ValueChange(object sender, EventArgs e)
        {
            string roleName = txtRoleName.Value;
            ValidateResult validateRoleName = _roleValidate.IsValidRoleName(roleName);

            if (validateRoleName.IsError)
            {
                txtRoleName.ErrorMessage = validateRoleName.ErrorMessage;
            }else
            {
                txtRoleName.ErrorMessage = "";

            }

        }

        private void txtRoleDesc_ValueChange(object sender, EventArgs e)
        {

            string roleDesc = txtRoleDesc.Value;
            ValidateResult validateRoleDesc = _roleValidate.IsValidRoleDescription(roleDesc);

            if (validateRoleDesc.IsError)
            {
                txtRoleDesc.ErrorMessage = validateRoleDesc.ErrorMessage;
            }else
            {
                txtRoleDesc.ErrorMessage = "";

            }

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);


        private void FrmTileMouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }


      


        private void customCheckbox33_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleStaff.ViewAllStaff = checkbox.Checked;
        }

        private void customCheckbox34_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleStaff.EditStaff = checkbox.Checked;
        }

        private void customCheckbox35_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleStaff.ImportStaffFile = checkbox.Checked;
        }

        private void customCheckbox37_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleStaff.CreateStaff = checkbox.Checked;
        }

        private void customCheckbox36_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleStaff.ExportStaffFile = checkbox.Checked;
        }

        private void customCheckbox38_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleStaff.RemoveStaff = checkbox.Checked;
        }

        private void customCheckbox2_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleManage.PermissionManagement = checkbox.Checked;
        }

        private void customCheckbox3_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleManage.GeneralConfiguration = checkbox.Checked;
        }

        private void customCheckbox4_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleManage.EditPrintingTemplate = checkbox.Checked;
        }

        private void customCheckbox5_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleManage.OrderProcessManagement = checkbox.Checked;
        }

        private void customCheckbox6_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleManage.EditStoreInformation = checkbox.Checked;
        }

        private void customCheckbox7_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleManage.ViewActiveLog = checkbox.Checked;
        }

        private void customCheckbox27_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleProduct.ViewProduct = checkbox.Checked;
        }

        private void customCheckbox29_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleProduct.ImportProductFile = checkbox.Checked;
        }

        private void customCheckbox31_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleProduct.CreateProduct = checkbox.Checked;
        }

        private void customCheckbox28_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleProduct.EditProduct = checkbox.Checked;
        }

        private void customCheckbox30_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleProduct.ExportProductFile = checkbox.Checked;
        }

        private void customCheckbox32_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleProduct.DeleteProduct = checkbox.Checked;
        }

        private void customCheckbox11_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleCustomer.ViewAssignedCustomers = checkbox.Checked;
        }

        private void customCheckbox18_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleCustomer.ViewAllCustomers = checkbox.Checked;
        }

        private void customCheckbox16_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleCustomer.EditCustomer = checkbox.Checked;
        }

        private void customCheckbox15_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleCustomer.CreateCustomer = checkbox.Checked;
        }

        private void customCheckbox17_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleCustomer.ImportCustomerFile = checkbox.Checked;
            _roleCustomer.ExportCustomerFile = checkbox.Checked;
        }

        private void customCheckbox19_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleCustomer.DeleteCustomer = checkbox.Checked;
        }

        private void customCheckbox23_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleOrder.ViewAssignedOrder = checkbox.Checked;
        }

        private void customCheckbox24_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleOrder.EditOrder = checkbox.Checked;
        }

        private void customCheckbox25_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleOrder.ViewAllOrder = checkbox.Checked;
        }

        private void customCheckbox26_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleOrder.ApproveOrder = checkbox.Checked;
        }

        private void customCheckbox39_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleOrder.CreateOrder = checkbox.Checked;
        }

        private void customCheckbox40_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleOrder.CancelOrder = checkbox.Checked;
        }

        private void customCheckbox41_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleOrder.ImportOrderFile = checkbox.Checked;
        }

        private void customCheckbox42_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleOrder.ExportOrderFile = checkbox.Checked;
        }

        private void customCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleInvetoryInspection.ViewInVentoryCount = checkbox.Checked;
        }

        private void customCheckbox10_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleInvetoryInspection.CreateInventoryCount = checkbox.Checked;
        }

        private void customCheckbox13_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleInvetoryInspection.DeleteInventoryCount = checkbox.Checked;
        }

        private void customCheckbox21_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleInvetoryInspection.ExportInventoryCountFile = checkbox.Checked;
        }

        private void customCheckbox9_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleInvetoryInspection.EditInventoryCount = checkbox.Checked;
        }

        private void customCheckbox12_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleInvetoryInspection.BalanceInventory = checkbox.Checked;
        }

        private void customCheckbox14_CheckedChanged(object sender, EventArgs e)
        {
              Guna2ImageCheckBox checkbox = (Guna2ImageCheckBox)sender;
            _roleInvetoryInspection.ImportInventoryCountFile = checkbox.Checked;
        }

       
    }
}
