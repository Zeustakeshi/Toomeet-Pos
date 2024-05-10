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
using Toomeet_Pos.Entites;
using Toomeet_Pos.UI.Validations;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmChangePassword : Form
    {

        private Staff _currentStaff;
        private readonly IAuthService _authService;
        private readonly IStaffService _staffService;
        private readonly IStaffValidate _staffValidate;


        public FrmChangePassword()
        {
            InitializeComponent();

            _authService = Program.GetService<IAuthService>();
            _staffService = Program.GetService<IStaffService>();
            _staffValidate = Program.GetService<IStaffValidate>();

            _currentStaff = _authService.GetAuthenticatedStaff();
        }


        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            lbPasswordError.Text = "";
            lbNewPasswordError.Text = "";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string currentPassword = txtPassword.Text;

            ValidateResult validateCurrentPassword = _staffValidate.IsValidPassword(currentPassword);

            if  (validateCurrentPassword.IsError)
            {
                lbPasswordError.Text = validateCurrentPassword.ErrorMessage;
                txtPassword.Focus();
                return;

            }


            string newPassword = txtNewPassword.Text;

            ValidateResult validateNewPassword = _staffValidate.IsValidPassword(newPassword);


            if (validateNewPassword.IsError)
            {
                lbNewPasswordError.Text = validateNewPassword.ErrorMessage;
                txtNewPassword.Focus();
                return;
            }

            btnSave.Enabled = false;
            try
            {
                _staffService.UpdatePassword(
                    new DTOs.ChangePasswordDto ()
                    {
                        StaffId = _currentStaff.Id,
                        NewPassword = newPassword,
                        CurrentPassword = currentPassword
                    }    
                );
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message,
                    "Đổi mật khẩu thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            btnSave.Enabled = true;

            

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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string currentPassword = txtPassword.Text;

            ValidateResult validateCurrentPassword = _staffValidate.IsValidPassword(currentPassword);

            if (validateCurrentPassword.IsError)
            {
                lbPasswordError.Text = validateCurrentPassword.ErrorMessage;
                txtPassword.Focus();
                return;
            }else
            {
                lbPasswordError.Text = "";
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;

            ValidateResult validateNewPassword = _staffValidate.IsValidPassword(newPassword);

            if (validateNewPassword.IsError)
            {
                lbNewPasswordError.Text = validateNewPassword.ErrorMessage;
                txtNewPassword.Focus();
                return;
            }
            else
            {
                lbNewPasswordError.Text = "";
            }
        }
    }
}
