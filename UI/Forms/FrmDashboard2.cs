using System;
using System.Windows.Forms;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites;
using Toomeet_Pos.UI.Forms.Products;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmDashboard2 : Form
    {

        private Staff _currentStaff;
        private readonly IRoleService _roleService;

        public FrmDashboard2(
            Staff staff
        )
        {
            InitializeComponent();
            _currentStaff = staff;
            _roleService = Program.GetService<IRoleService>();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = _currentStaff.Name;
            lbRole.Text = _currentStaff.Role.Name;


            CheckCanSetting();
            CheckCanManageProduct();
        }

        private void CheckCanSetting()
        {
            if (!_roleService.CanGeneralConfiguration(_currentStaff))
            {
                btnSetting.Enabled = false;
                btnSetting.Visible = false;
            }
        }

        private void CheckCanManageProduct()
        {
            if (!_roleService.CanViewProduct(_currentStaff))
            {
                btnManageProduct.Enabled = false;
                btnManageProduct.Visible = false;
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();

            Hide();
            frmLogin.ShowDialog();
            Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
           // FrmUpdateStore frmSetting = new FrmSetting();
            Hide();
            //frmSetting.ShowDialog();
            Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
            Close();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct(_currentStaff, _currentStaff.Workplace);
            Hide();
            frmProduct.ShowDialog();
            Show();
        }
    }
}
