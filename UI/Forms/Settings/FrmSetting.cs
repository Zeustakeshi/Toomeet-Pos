using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites;
using Toomeet_Pos.UI.Forms.settings;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmSetting : Form
    {

        private readonly Staff _currentStaff;
        private readonly IRoleService _roleService;
        private readonly IAuthService _authService;


        public FrmSetting()
        {
            InitializeComponent();
            _roleService = Program.GetService<IRoleService>();
            _authService = Program.GetService<IAuthService>();
            _currentStaff = _authService.GetAuthenticatedStaff();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            CheckCanManageStaff();
            CheckCanManageStoreInfo();
            CheckCanMaangeInventoryAndProduct();
        }

        private void CheckCanManageStaff()
        {
            if (!_roleService.CanViewAllStaff(_currentStaff))
            {
                //btnAccountSetting.Enabled = false;
                //btnAccountSetting.Visible = false;
            }
        }

        private void CheckCanManageStoreInfo()
        {
            if (!_roleService.CanEditStoreInfo(_currentStaff))
            {
                //btnStoreInfo.Enabled = false;
                //btnStoreInfo.Visible = false;
            }
        }

        private void CheckCanMaangeInventoryAndProduct()
        {
            //if (!_currentStaff.Role.Product.ViewProduct ||
            //    !_currentStaff.Role.Product.EditProduct
            //    )
            //{
            //    btnProductStockSetting.Enabled = false;
            //    btnProductStockSetting.Visible = false;
            //}
        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            FrmStaffManage frmStaffManage = new FrmStaffManage(_currentStaff);
            frmStaffManage.ShowDialog();
        }

        private void OpenStoreSetting(object sender, EventArgs e)
        {
            FrmUpdateStore FrmUpdateStore = new FrmUpdateStore();
            FrmUpdateStore.ShowDialog();
        }

        private void OpenStaffManage (object sender, EventArgs e)
        {
            FrmManageStaff frmManageStaff = new FrmManageStaff();

            frmManageStaff.ShowDialog();

        }
    }
}
