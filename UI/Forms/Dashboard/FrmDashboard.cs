using Guna.UI2.WinForms;
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
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites;
using Toomeet_Pos.UI.Forms.Order;
using Toomeet_Pos.UI.Forms.Overview;
using Toomeet_Pos.UI.Forms.Staffs;

namespace Toomeet_Pos.UI.Forms.Dashboard
{
    public partial class FrmDashboard : Form
    {

        private bool _isSidebarExpand;
        private Guna2GradientButton _currentSidebarItemActive;
        private Form _currentSubForm;
        private Staff _currentStaff;
        private Store _store;
        private readonly IRoleService _roleService;
        private readonly IAuthService _authService;


        public FrmDashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _isSidebarExpand = true;
            _currentSidebarItemActive = sidebarItemOverview;
            ActiveSideBarItem(_currentSidebarItemActive);
            OpenSubForm(new FrmOverview());
            _roleService = Program.GetService<IRoleService>();
            _authService = Program.GetService<IAuthService>();

            _currentStaff = _authService.GetAuthenticatedStaff();
            _store = _authService.GetStoreInfo();

        }

        private void TestDashboard_Load(object sender, EventArgs e)
        {
            OpenSideBar();

            /// show welcome message

            lbWelcome.Text = "Xin chào, " + _currentStaff.Name;
            lbWelcomeRole.Text = _currentStaff.Role.Name;

            // check role
            if (!_roleService.CanGeneralConfiguration(_currentStaff))
            {
                sidebarItemAccount.Visible = false;
            }
        }


     
      

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            if (_isSidebarExpand) CloseSideBar();
            else OpenSideBar();
        }


        private void OpenSideBar ()
        {
            _isSidebarExpand = true;
            panelSidebar.Width = panelSidebar.MaximumSize.Width;
            txtSearch.PlaceholderText = "Tìm kiếm";
            sidebarItemOverview.Text = "Tổng quan";
            sidebarItemOrder.Text = "Đơn hàng";
            sidebarItemProduct.Text = "Sản phẩm";
            sidebarItemCustomer.Text = "Khách hàng";
            sidebarItemCash.Text = "Sổ quỹ";
            sidebarItemReport.Text = "Báo cáo";
            sidebarItemSoldAtTheCounter.Text = "Bán tại quầy";
            sidebarItemSettings.Text = "Cấu hình";
            sidebarItemAccount.Text = "Tài khoản";
            btnLogout.Text = "Đăng xuất";
        }

        private void CloseSideBar ()
        {
            _isSidebarExpand = false;
            panelSidebar.Width = panelSidebar.MinimumSize.Width;
            txtSearch.PlaceholderText = "";
            sidebarItemOverview.Text = "";
            sidebarItemOrder.Text = "";
            sidebarItemProduct.Text = "";
            sidebarItemCustomer.Text = "";
            sidebarItemCash.Text = "";
            sidebarItemReport.Text = "";
            sidebarItemSoldAtTheCounter.Text = "";
            sidebarItemAccount.Text = "";
            sidebarItemSettings.Text = "";
            btnLogout.Text = "";
        }

        private void OpenSubForm (Form frmSub)
        {
            if (_currentSubForm != null) _currentSubForm.Close();
            _currentSubForm = frmSub;
            frmSub.TopLevel = false;
            frmSub.FormBorderStyle = FormBorderStyle.None;
            frmSub.Dock = DockStyle.Fill;
            subFormContainer.Controls.Add(frmSub);
            subFormContainer.Tag = frmSub;
            frmSub.BringToFront();
            frmSub.Show();
        }

        private void ActiveSideBarItem(object sender)
        {
            DeactiveSidebarItem();
            _currentSidebarItemActive =  (Guna2GradientButton)sender;
            _currentSidebarItemActive.Checked = true;
        }

        private void DeactiveSidebarItem ()
        {
            if (_currentSidebarItemActive == null) return;
            _currentSidebarItemActive.Checked = false;
        }

        private void sidebarItemOverview_Click(object sender, EventArgs e)
        {
            ActiveSideBarItem(sender);
            OpenSubForm(new FrmOverview());
        }
    

        private void sidebarItemProduct_Click(object sender, EventArgs e)
        {
            ActiveSideBarItem(sender);

        }

        private void sidebarItemCustomer_Click(object sender, EventArgs e)
        {
            ActiveSideBarItem(sender);
        }

        private void sidebarItemCash_Click(object sender, EventArgs e)
        {
            ActiveSideBarItem(sender);
        }

        private void sidebarItemReport_Click(object sender, EventArgs e)
        {
            ActiveSideBarItem(sender);
        }

        private void sidebarItemSoldAtTheCounter_Click(object sender, EventArgs e)
        {
            ActiveSideBarItem(sender);
        }

        private void sidebarItemSettings_Click(object sender, EventArgs e)
        {
            ActiveSideBarItem(sender);
            OpenSubForm(new FrmSetting());
        }

        private void sidebarItemOrder_Click(object sender, EventArgs e)
        {
            ActiveSideBarItem(sender);
            OpenSubForm(new FrmOrder());
        }

        private void sidebarItemAccount_Click(object sender, EventArgs e)
        {
            ActiveSideBarItem(sender);
            OpenSubForm(new FrmUpdateAccount());

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void guna2ShadowPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            _authService.SetAuthenticatedStaff(null);

            FrmLogin frmLogin = new FrmLogin();

            Hide();
            frmLogin.ShowDialog();
            Close();

        }
    }
}
