using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;
using Toomeet_Pos.UI.Validations;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmAddStaff : Form
    {


        private readonly IRoleService _roleService;
        private readonly IAuthService _authService;
        private readonly IStaffValidate _staffValidate;
        private readonly IStaffService _staffService;

        private Store _store;
        private Staff _currentStaff;

        private List<Role> _roles;

        public FrmAddStaff()
        {
            InitializeComponent();

            _roleService = Program.GetService<IRoleService>();
            _authService = Program.GetService<IAuthService>();
            _staffService = Program.GetService<IStaffService>();

            _staffValidate = Program.GetService<IStaffValidate>();

            _store = _authService.GetStoreInfo();
            _currentStaff = _authService.GetAuthenticatedStaff();
                

            if (!_roleService.CanManageRole(_currentStaff))
            {
                btnAddRole.Visible = false;
                btnAddRole.Enabled = false;
                llbViewAlRole.Enabled = false;
                llbViewAlRole.Visible = false;
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

        private void FrmAddStaff_Load(object sender, EventArgs e)
        {

            LoadGender();
            LoadAllRole();
        }


        private void LoadGender()
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

        private void LoadAllRole ()
        {
            _roles = _roleService.GetAllRoleByStoreId(_store.Id);
            cbRole.Items.Clear();

            foreach (Role role in _roles)
            {
                cbRole.Items.Add(role.Name);
            }

            if (cbRole.Items.Count > 0) cbRole.SelectedIndex = 0;
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            FrmAddRole frmAddRole = new FrmAddRole();
            Hide();
            frmAddRole.ShowDialog();
            Show();
            LoadAllRole();
        }

        private void llbViewAlRole_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmManageRole frmManageRole = new FrmManageRole();
            Hide();
            frmManageRole.ShowDialog();
            Show();
            LoadAllRole();

        }

        private void btnSendInvite_Click(object sender, EventArgs e)
        {
            string name = txtName.Value;

            ValidateResult nameValidate = _staffValidate.IsValidName(name);

            if (nameValidate.IsError)
            {
                txtName.ErrorMessage = nameValidate.ErrorMessage;
                return;
            }


            string phone = txtPhone.Value;

            ValidateResult phoneValidate = _staffValidate.IsValidPhone(phone);

            if (phoneValidate.IsError)
            {
                txtPhone.ErrorMessage = phoneValidate.ErrorMessage;
                return;
            }


            string email = txtEmail.Value;

            ValidateResult emailValidate = _staffValidate.IsValidEmail(email);
            
            if (emailValidate.IsError)
            {
                txtEmail.ErrorMessage = emailValidate.ErrorMessage;
                return;
            }


            string description = txtDescription.Value;

            ValidateResult descValidate = _staffValidate.IsValidDescription(description);

            if (descValidate.IsError)
            {
                txtDescription.ErrorMessage = descValidate.ErrorMessage;
                return;
            }


            DateTime birthday = datetimeBirthday.Value;

            ValidateResult birthDayValidate = _staffValidate.IsValidBirthday(birthday);

            if (birthDayValidate.IsError)
            {
                lbBirthdayError.Text = birthDayValidate.ErrorMessage;
                datetimeBirthday.Focus();
                return;
            }


            StaffGender selectedGender = (StaffGender)cbGender.SelectedValue;


            Staff staff = new Staff()
            {
                Name = name,
                Phone = phone,
                Email = email,
                Description = description,
                Gender = selectedGender,
                Birthday = birthday,
                Status = StaffStatus.NOT_STARTED,
            };

            NewStaffDto createStaffDto = new NewStaffDto()
            {
                Staff = staff,
                Store = _store,
                Role = _roles[cbRole.SelectedIndex]
            };


            btnSendInvite.Enabled = false;
            try
            {

                _staffService.SaveStaff(createStaffDto);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Thêm nhân viên thất bại: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnSendInvite.Enabled = true;


        }

        private void txtName_ValueChange(object sender, EventArgs e)
        {
            string name = txtName.Value;

            ValidateResult nameValidate = _staffValidate.IsValidName(name);

            if (nameValidate.IsError)
            {
                txtName.ErrorMessage = nameValidate.ErrorMessage;
                return;
            }
            txtName.ErrorMessage = "";
        }

        private void txtPhone_ValueChange(object sender, EventArgs e)
        {

            string phone = txtPhone.Value;

            ValidateResult phoneValidate = _staffValidate.IsValidPhone(phone);

            if (phoneValidate.IsError)
            {
                txtPhone.ErrorMessage = phoneValidate.ErrorMessage;
                return;
            }
             
            txtPhone.ErrorMessage = "";

        }

        private void txtEmail_ValueChange(object sender, EventArgs e)
        {

            string email = txtEmail.Value;

            ValidateResult emailValidate = _staffValidate.IsValidEmail(email);

            if (emailValidate.IsError)
            {
                txtEmail.ErrorMessage = emailValidate.ErrorMessage;
                return;
            }

            txtEmail.ErrorMessage = "";
        }

        private void txtDescription_ValueChange(object sender, EventArgs e)
        {

            string description = txtDescription.Value;

            ValidateResult descValidate = _staffValidate.IsValidDescription(description);

            if (descValidate.IsError)
            {
                txtDescription.ErrorMessage = descValidate.ErrorMessage;
                return;
            }

            txtDescription.ErrorMessage = "";
        }

        private void datetimeBirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthday = datetimeBirthday.Value;

            ValidateResult birthDayValidate = _staffValidate.IsValidBirthday(birthday);

            if (birthDayValidate.IsError)
            {
                lbBirthdayError.Text = birthDayValidate.ErrorMessage;
                datetimeBirthday.Focus();
                return;
            }

            lbBirthdayError.Text = "";
        }
    }
}
