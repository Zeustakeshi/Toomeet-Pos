using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.Entites;
using Toomeet_Pos.UI.Validations;

namespace Toomeet_Pos.UI.Forms.Staffs
{
    public partial class FrmUpdateAccount : Form
    {

        private readonly IStaffService _staffService;
        private readonly IAuthService _authService;
        private readonly IStaffValidate _staffValidate;
        private readonly IImageService _imageService;
        private Staff _currentStaff;

        public FrmUpdateAccount()
        {
            InitializeComponent();

            _authService = Program.GetService<IAuthService>();
            _staffService = Program.GetService<IStaffService>();
            _staffValidate = Program.GetService<IStaffValidate>();
            _imageService = Program.GetService<IImageService>();
            _currentStaff = _authService.GetAuthenticatedStaff();
        }

        private void FrmUpdateAccount_Load(object sender, EventArgs e)
        {
            lbAddressError.Text = "";
            lbPhoneError.Text = "";
            lbEmailError.Text = "";

            LoadGender();
            LoadStaffInfo();
            LoadStaffPhoto();

        }

        private void LoadStaffPhoto ()
        {
            if (_currentStaff.Photo == null) return;
            pictureBoxAvatar.Image = _imageService.ByteArrayToImage(_currentStaff.Photo);
        }


        private void LoadStaffInfo ()
        {
            txtName.Text = _currentStaff.Name;
            txtEmail.Text = _currentStaff.Email;
            txtAddress.Text = _currentStaff.Address;
            txtPhone.Text = _currentStaff.Phone;
            datetimeBirthday.Value = _currentStaff.Birthday;
          
            
            switch (_currentStaff.Gender)
            {
                case StaffGender.MALE:
                {
                    cbGender.SelectedIndex = 0;
                    break;
                }
                case StaffGender.FEMALE:
                {
                    cbGender.SelectedIndex = 1;
                    break;
                }
                case StaffGender.OTHER:
                {
                    cbGender.SelectedIndex = 2;
                    break;
                }
                default:
                {
                    cbGender.SelectedIndex = 1;
                    break;
                }
            }
        }


        private void LoadGender ()
        {
            Dictionary<StaffGender, string> genderDict = new Dictionary<StaffGender, string>
            {
                { StaffGender.MALE, "Nam" },
                { StaffGender.FEMALE, "Nữ" },
                { StaffGender.OTHER, "Khác" }
            };


            cbGender.DataSource = new BindingSource(genderDict, null);

            cbGender.DisplayMember = "Value";
            cbGender.ValueMember = "Key";
        }

        private void llbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            string name = txtName.Text;
            ValidateResult validateName = _staffValidate.IsValidName(name);
            if (validateName.IsError)
            {
                lbNameError.Text = validateName.ErrorMessage;
                txtName.Focus();
                return;
            }

            string phone = txtPhone.Text;
            ValidateResult validatePhone = _staffValidate.IsValidPhone(phone);

            if (validatePhone.IsError)
            {
                lbPhoneError.Text = validatePhone.ErrorMessage;
                txtPhone.Focus();
                return;
            }


            string email = txtEmail.Text;
            ValidateResult validateEmail = _staffValidate.IsValidEmail(email);

            if (email.Length > 0 && validateEmail.IsError)
            {
                lbEmailError.Text = validateName.ErrorMessage;
                txtEmail.Focus();
                return;
            } 


            string address = txtAddress.Text;
            ValidateResult validateAddress = _staffValidate.IsValidAddress(address);

            if (address.Length >  0 && validateAddress.IsError)
            {
                lbAddressError.Text = validateAddress.ErrorMessage;
                txtAddress.Focus();
                return;
            }


            DateTime birthday = datetimeBirthday.Value;
            ValidateResult validateBirthday = _staffValidate.IsValidBirthday(birthday);

            if (validateBirthday.IsError)
            {
                lbBirthdayError.Text = validateBirthday.ErrorMessage;
                datetimeBirthday.Focus();
                return;
            }


            StaffGender selectedGender = (StaffGender)cbGender.SelectedValue;


            _currentStaff.Email = email.Length > 0 ? email : null;
            _currentStaff.Address = address.Length > 0 ? address : null;

            _currentStaff.Gender = selectedGender;
            _currentStaff.Name = name;
            _currentStaff.Phone = phone;
            _currentStaff.Birthday = birthday;

            btnUpdate.Enabled = false;
            try
            {
                Staff updatedStaff = _staffService.UpdateStaff(_currentStaff);
                _currentStaff = updatedStaff;
                _authService.SetAuthenticatedStaff(updatedStaff);

                MessageBox.Show(
                   "Thông tin tài khoản đã được cập nhật",
                   "Cập nhật tài khoản thành công",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
               );
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine("Property: {0} Error: {1}",
                            validationError.PropertyName, validationError.ErrorMessage);

                        MessageBox.Show(
                           "Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage,
                           "Cập nhật tài khoản thất bại",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error
                       );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message,
                    "Cập nhật tài khoản thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            btnUpdate.Enabled = true;
        }


        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() != DialogResult.OK) return;

            string path = openFile.FileName;


            try
            {
                _currentStaff.Photo = _imageService.ImageToByteArray(path);
                _staffService.UpdateStaff(_currentStaff);
                pictureBoxAvatar.Image = Image.FromFile(path);

                _authService.SetAuthenticatedStaff(_currentStaff);

                MessageBox.Show(
                   "Ảnh đã tải lên thành công",
                   "Cập nhật tài khoản thành công",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
               );

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message,
                    "Tải ảnh lên thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

       

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text;
            ValidateResult validateName = _staffValidate.IsValidName(name);
            if (validateName.IsError)
            {
                lbNameError.Text = validateName.ErrorMessage;
                txtName.Focus();
            }else
            {
                lbNameError.Text = "";
            }

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            ValidateResult validatePhone = _staffValidate.IsValidPhone(phone);

            if (validatePhone.IsError)
            {
                lbPhoneError.Text = validatePhone.ErrorMessage;
                txtPhone.Focus();
            }else
            {
                lbPhoneError.Text = "";
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            ValidateResult validateEmail = _staffValidate.IsValidEmail(email);

            if (email.Length > 0 && validateEmail.IsError)
            {
                lbEmailError.Text = validateEmail.ErrorMessage;
                txtEmail.Focus();
            }else
            {
                lbEmailError.Text = "";
            }
        }

        private void datetimeBirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthday = datetimeBirthday.Value;
            ValidateResult validateBirthday = _staffValidate.IsValidBirthday(birthday);

            if (validateBirthday.IsError)
            {
                lbBirthdayError.Text = validateBirthday.ErrorMessage;
                datetimeBirthday.Focus();
            }else
            {
                lbBirthdayError.Text = "";
            }

        }

    

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

            string address = txtAddress.Text;
            ValidateResult validateAddress = _staffValidate.IsValidAddress(address);

            if (address.Length > 0 && validateAddress.IsError)
            {
                lbAddressError.Text = validateAddress.ErrorMessage;
                txtAddress.Focus();
            }else
            {
                lbAddressError.Text = "";
            }

        }

        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.ShowDialog();

        }

       
    }
}
