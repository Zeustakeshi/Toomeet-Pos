using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.Entites;
using Toomeet_Pos.UI.Forms.Dashboard;
using Toomeet_Pos.UI.Validations;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmRegister : Form
    {
        private readonly IStaffValidate _staffValidate;
        private readonly IStoreValidate _storeValidate;
        private readonly IStoreService _storeService;
        private readonly IAuthService _authService;
        public FrmRegister()
        {
            InitializeComponent();
            _authService = Program.GetService<IAuthService>();
            _staffValidate = Program.GetService<IStaffValidate>();
            _storeValidate = Program.GetService<IStoreValidate>();
            _storeService = Program.GetService<IStoreService>();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            lbPasswordError.Text = "";
            lbOwnerError.Text = "";
            lbPhoneError.Text = "";
            lbStoreNameError.Text = "";
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string storeName = txtStoreName.Text;
            string ownerName = txtOwnerName.Text;
            string password = txtPassword.Text;
            string ownerPhone = txtPhone.Text;


            ValidateResult validateStoreName = _storeValidate.IsValidName(storeName);
            ValidateResult validateOwner = _staffValidate.IsValidName(ownerName);
            ValidateResult validatePassword = _staffValidate.IsValidPassword(password);
            ValidateResult validateOwnerPhone = _staffValidate.IsValidPhone(ownerPhone);

        

            if (!validateStoreName.IsSuccess)
            {
                lbStoreNameError.Text = validateStoreName.ErrorMessage;
                txtStoreName.Focus();
                return;
            }

            if (!validateOwner.IsSuccess)
            {
                lbOwnerError.Text = validateOwner.ErrorMessage;
                txtOwnerName.Focus();
                return;
            }

            if (!validateOwnerPhone.IsSuccess)
            {
                lbPhoneError.Text = validateOwnerPhone.ErrorMessage;
                txtPhone.Focus();
                return;
            }

            if (!validatePassword.IsSuccess)
            {
                lbPasswordError.Text = validatePassword.ErrorMessage;
                txtPassword.Focus();
                return;
            }

            //// handle register

            try
            {
                btnRegister.Enabled = false;

                Store newStore = _storeService.RegisterStore(new DTOs.NewStoreDto()
                {
                    OwnerName = ownerName,
                    OwnerPassword = password,
                    OwnerPhone = ownerPhone,
                    StoreName = storeName
                });

                _authService.SetAuthenticatedStaff(newStore.Owner);
                _authService.SetStoreInfo(newStore);

                FrmDashboard frmDashboard = new FrmDashboard();

                Hide();
                frmDashboard.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message

                );
            }

            btnRegister.Enabled = true;


        }

        private void txtStoreName_TextChanged(object sender, EventArgs e)
        {
            string storeName = txtStoreName.Text;
            ValidateResult validateStoreName = _storeValidate.IsValidName(storeName);

            if (!validateStoreName.IsSuccess)
            {
                lbStoreNameError.Text = validateStoreName.ErrorMessage;
                return;
            }
            else
            {
                lbStoreNameError.Text = "";
            }
        }

        private void txtOwnerName_TextChanged(object sender, EventArgs e)
        {
            string ownerName = txtOwnerName.Text;
            ValidateResult validateOwner = _staffValidate.IsValidName(ownerName);
            if (!validateOwner.IsSuccess)
            {
                lbOwnerError.Text = validateOwner.ErrorMessage;
                return;
            }
            else
            {
                lbOwnerError.Text = "";
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string ownerPhone = txtPhone.Text;
            ValidateResult validateOwnerPhone = _staffValidate.IsValidPhone(ownerPhone);

            if (!validateOwnerPhone.IsSuccess)
            {
                lbPhoneError.Text = validateOwnerPhone.ErrorMessage;
                return;
            }
            else
            {
                lbPhoneError.Text = "";
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            ValidateResult validatePassword = _staffValidate.IsValidPassword(password);

            if (!validatePassword.IsSuccess)
            {
                lbPasswordError.Text = validatePassword.ErrorMessage;
                return;
            }
            else
            {
                lbPasswordError.Text = "";
            }
        }
    }
}
