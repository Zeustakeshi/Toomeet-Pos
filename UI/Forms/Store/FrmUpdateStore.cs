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
    public partial class FrmUpdateStore : Form
    {

        private readonly IStoreService _storeService;
        private readonly IStaffService _staffService;
        private readonly IAuthService _authService;
        private readonly IStoreValidate _storeValidate;
        private readonly IStaffValidate _staffValidate;

        private  Store _store;
        private  Staff _currentStaff;

        public FrmUpdateStore()
        {
            InitializeComponent();

            _storeService = Program.GetService<IStoreService>();
            _staffService = Program.GetService<IStaffService>();
            _authService = Program.GetService<IAuthService>();
            _staffValidate = Program.GetService<IStaffValidate>();
            _storeValidate = Program.GetService<IStoreValidate>();
            
      
        }



        private void FrmUpdateStore_Load(object sender, EventArgs e)
        {
            LoadData();

            lbAddressError.Text = "";
            lbStoreNameError.Text = "";
            lbEmailError.Text = "";
            lbPhoneError.Text = "";

        }


        private void LoadData ()
        {
            _store = _authService.GetStoreInfo();
            _currentStaff = _authService.GetAuthenticatedStaff();

            txtStoreName.Text = _store.Name;
            txtPhone.Text = _store.Owner.Phone;
            txtEmail.Text = _store.Owner.Email;
            txtAddress.Text = _store.Address;
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

   

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string name = txtStoreName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;


            ValidateResult validateName = _storeValidate.IsValidName(name);
            ValidateResult validatePhone = _staffValidate.IsValidPhone(phone);
            ValidateResult validateEmail = _staffValidate.IsValidEmail(email);
            ValidateResult validateAddress = _storeValidate.IsValidName(address);
            

            if (validateName.IsError)
            {
                lbStoreNameError.Text = validateName.ErrorMessage;
                txtStoreName.Focus();
                return;
            }

            if (validatePhone.IsError)
            {
                lbPhoneError.Text = validatePhone.ErrorMessage;
                txtPhone.Focus();
                return;
            }

            if (email.Length > 0 && validateEmail.IsError)
            {
                lbEmailError.Text = validateEmail.ErrorMessage;
                txtEmail.Focus();
                return;
            }


            if (address.Length > 0 && validateAddress.IsError)
            {
                lbAddressError.Text = validateAddress.ErrorMessage;
                txtAddress.Focus(); 
                return;
            }


            _store.Name = name;
            _store.Owner.Phone = phone;
            _store.Owner.Email = email.Length > 0 ? email : null;
            _store.Address = address.Length > 0 ? address : null;


            try
            {
                Store updatedStore = _storeService.UpdateStore(_store);
                _store = updatedStore;
                _currentStaff.Phone = phone;
                _currentStaff.Email = email;
                _authService.SetStoreInfo(_store);
                _authService.SetAuthenticatedStaff(_currentStaff);

                MessageBox.Show(
                    "Thông tin cửa hàng đã được cập nhật",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message, 
                    "Cập nhật thất bại", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }

         

           
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            Close();

        }

    }
}
