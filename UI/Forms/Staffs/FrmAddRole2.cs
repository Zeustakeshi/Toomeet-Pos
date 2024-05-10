using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Roles;

namespace Toomeet_Pos.UI.Forms.Staffs
{
    public partial class FrmAddRole2 : Form
    {

        private readonly Store _store;
        private readonly IRoleService _roleService;
        private RoleManage _roleManage;
        private RoleCustomer _roleCustomer;
        private RoleStaff _roleStaff;
        private RoleOrder _roleOrder;
        private RoleProduct _roleProduct;
        private RoleInvetoryInspection _roleInvetoryInspection;

        public FrmAddRole2(Store store)
        {
            InitializeComponent();
            _store = store;
            _roleService = Program.GetService<IRoleService>();
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


        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Role role = new Role()
                {
                    Name = txtRoleName.Text,
                    Description = txtRoleDescription.Text,
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

            }catch(Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Thêm vai trò thất bại: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void chbManagePermisstion_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleManage.PermissionManagement = checkBox.Checked;
        }

        private void chbManagePayment_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleManage.PaymentManagement = checkBox.Checked;
        }

        private void chbManageStoreInfo_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleManage.EditStoreInformation = checkBox.Checked;
        }

        private void chbManageOrderProcess_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleManage.OrderProcessManagement = checkBox.Checked;
        }

        private void guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleManage.EditPrintingTemplate = checkBox.Checked;
        }

        private void guna2CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleManage.ViewActiveLog = checkBox.Checked;
        }

        private void guna2CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleManage.GeneralConfiguration = checkBox.Checked;
        }

        private void chbViewAllStaff_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleStaff.ViewAllStaff = checkBox.Checked;
        }

        private void chbAddStaff_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleStaff.CreateStaff = checkBox.Checked;
        }

        private void chbEditStaff_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleStaff.EditStaff = checkBox.Checked;
        }

        private void chbDeleteStaff_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleStaff.RemoveStaff = checkBox.Checked;
        }

        private void guna2CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleStaff.ImportStaffFile = checkBox.Checked;
        }

        private void guna2CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleStaff.ExportStaffFile = checkBox.Checked;
        }

        private void guna2CheckBox19_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleCustomer.ViewAssignedCustomers = checkBox.Checked;
        }

        private void guna2CheckBox18_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleCustomer.ViewAllCustomers = checkBox.Checked;
        }

        private void guna2CheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleCustomer.CreateCustomer = checkBox.Checked;
        }

        private void guna2CheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleCustomer.DeleteCustomer = checkBox.Checked;
        }

        private void guna2CheckBox15_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleCustomer.EditCustomer = checkBox.Checked;
        }

        private void guna2CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleCustomer.ExportCustomerFile = checkBox.Checked;
        }

        private void guna2CheckBox20_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleCustomer.ImportCustomerFile = checkBox.Checked;
        }

        private void guna2CheckBox27_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleProduct.ViewProduct = checkBox.Checked;
        }

        private void guna2CheckBox26_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleProduct.CreateProduct = checkBox.Checked;
        }

        private void guna2CheckBox24_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleProduct.EditProduct = checkBox.Checked;
        }

        private void guna2CheckBox25_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleProduct.DeleteProduct = checkBox.Checked;
        }

        private void guna2CheckBox23_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleProduct.ImportProductFile = checkBox.Checked;
        }

        private void guna2CheckBox22_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleProduct.ExportProductFile = checkBox.Checked;
        }

        private void guna2CheckBox34_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleOrder.ViewAssignedOrder = checkBox.Checked;
        }

        private void guna2CheckBox33_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleOrder.ViewAllOrder = checkBox.Checked;
        }

        private void guna2CheckBox31_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleOrder.CreateOrder = checkBox.Checked;
        }

        private void guna2CheckBox32_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleOrder.EditOrder = checkBox.Checked;
        }

        private void guna2CheckBox29_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleOrder.ApproveOrder = checkBox.Checked;
        }

        private void guna2CheckBox28_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleOrder.CancelOrder = checkBox.Checked;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleOrder.ImportOrderFile = checkBox.Checked;
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleOrder.ExportOrderFile = checkBox.Checked;
        }

        private void guna2CheckBox44_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleInvetoryInspection.ViewInVentoryCount = checkBox.Checked;
        }

        private void guna2CheckBox43_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleInvetoryInspection.CreateInventoryCount = checkBox.Checked;
        }

        private void guna2CheckBox42_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleInvetoryInspection.EditInventoryCount = checkBox.Checked;
        }

        private void guna2CheckBox40_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleInvetoryInspection.BalanceInventory = checkBox.Checked;
        }

        private void guna2CheckBox36_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleInvetoryInspection.DeleteInventoryCount = checkBox.Checked;
        }

        private void guna2CheckBox37_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleInvetoryInspection.ImportInventoryCountFile = checkBox.Checked;
        }

        private void guna2CheckBox38_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            _roleInvetoryInspection.ExportInventoryCountFile = checkBox.Checked;
        }

       
    }
}
