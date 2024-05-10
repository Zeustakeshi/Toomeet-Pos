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
using Toomeet_Pos.Entites;
using Toomeet_Pos.UI.Forms.Dashboard;
using Toomeet_Pos.UI.Validations;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly IAuthValidate _authValidate;
        private readonly IStaffService _staffService;
        private readonly IStaffValidate _staffValidate;
        private readonly IAuthService _authService;
        public FrmLogin()
        {
            InitializeComponent();
            _authValidate = Program.GetService<IAuthValidate>();
            _staffService = Program.GetService<IStaffService>();
            _staffValidate = Program.GetService<IStaffValidate>();
            _authService = Program.GetService<IAuthService>();

            AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Value;
            ValidateResult validateUsername = _authValidate.IsValidUsername(username);


            if (validateUsername.IsError)
            {
                txtUsername.ErrorMessage = validateUsername.ErrorMessage;
                return;
            }

            string password = txtPassword.Value;
            ValidateResult validatePassword = _authValidate.IsValidPassword(password);


            if (validatePassword.IsError)
            {
                txtPassword.ErrorMessage = validatePassword.ErrorMessage;
                return;
            }
         

            try
            {
                btnLogin.Enabled = false;
                Staff staff = _staffService.Login(txtUsername.Value, txtPassword.Value);

                _authService.SetStoreInfo(staff.Workplace);
                _authService.SetAuthenticatedStaff(staff);

                FrmDashboard frmDashBoard = new FrmDashboard();
                Hide();
                frmDashBoard.ShowDialog();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    text: ex.GetBaseException().Message,
                    caption: "Đăng nhập không thành công",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error
                );
            }
            btnLogin.Enabled = true;

        }

       

        private void llbCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            Hide();
            frmRegister.ShowDialog();
            Close();
        }

        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPasssword frmForgotPasssword = new FrmForgotPasssword();

            Hide();
            frmForgotPasssword.ShowDialog();
            Show();
        }

        private void txtUsername_ValueChange(object sender, EventArgs e)
        {
            string username = txtUsername.Value;
            ValidateResult validateUsername = _authValidate.IsValidUsername(username);


            if (validateUsername.IsError)
            {
                txtUsername.ErrorMessage = validateUsername.ErrorMessage;
            }
            else
            {
                txtUsername.ErrorMessage = "";
            }

        }

        private void txtPassword_ValueChange(object sender, EventArgs e)
        {
            string password = txtPassword.Value;
            ValidateResult validatePassword = _authValidate.IsValidPassword(password);


            if (validatePassword.IsError)
            {
                txtPassword.ErrorMessage = validatePassword.ErrorMessage;
            }
            else
            {
                txtPassword.ErrorMessage = "";
            }
        }
    }
}
