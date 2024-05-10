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
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.UI.Forms.Staffs
{
    public partial class FrmAddStaff2 : Form
    {

        private readonly Store _store;
        private readonly Staff _currentStaff;
        private readonly IRoleService _roleService;
        private readonly IStaffService _staffService;
        private List<Role> _roles;

        public FrmAddStaff2(Store store, Staff currentStaff)
        {
            InitializeComponent();
            _store = store;
            _roleService = Program.GetService<IRoleService>();
            _staffService = Program.GetService<IStaffService>();
            _currentStaff = currentStaff;
            _roles = new List<Role>();
        }

        private void FrmAddStaff_Load(object sender, EventArgs e)
        {
            LoadRoles();
            CheckCanAddRole();
        }

        private void CheckCanAddRole ()
        {
            if (!_roleService.CanManageRole(_currentStaff))
            {
                btnAddRole.Enabled = false;
                btnAddRole.Visible = false;
            }
        }


        private void LoadRoles ()
        {
            _roles = _roleService.GetAllRoleByStoreId(_store.Id);

            cbRoles.Items.Clear();

            foreach (Role role in _roles)
            {
                cbRoles.Items.Add(role.Name);
            }

            if (cbRoles.Items.Count > 0)
            {
                cbRoles.SelectedIndex = 0;
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            FrmAddRole2 frmAddRole = new FrmAddRole2(_store);

            Hide();
            frmAddRole.ShowDialog();
            LoadRoles();
            Show();

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            Role role = _roles[cbRoles.SelectedIndex];
            
            try
            {

                if (role == null)
                {
                    throw new Exception("Vui lòng chọn vai tròn cho nhân viên này");
                }


                Staff staff = new Staff()
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Description = txtDescription.Text,
                    Phone = txtPhone.Text,
                    Password = txtPhone.Text,
                    Status = StaffStatus.WORKING
                };

                NewStaffDto createStaffDto = new NewStaffDto()
                {
                    Staff = staff,
                    Store = _store,
                    Role = role
                };

                Staff newStaff = _staffService.SaveStaff(createStaffDto);
                MessageBox.Show("Nhân viên " + newStaff.Name + " đã được thêm vào cửa hàng", "Thêm nhân viên thành công: ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Thêm nhân viên thất bại: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
