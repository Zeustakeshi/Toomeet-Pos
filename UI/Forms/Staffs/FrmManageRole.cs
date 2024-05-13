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

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmManageRole : Form
    {

        private readonly IRoleService _roleService;
        private readonly IAuthService _authService;
        private Staff _currentStaff;
        private Store _store;
        private List<Role> _roles;

        public FrmManageRole()
        {
            InitializeComponent();

            _roleService = Program.GetService<IRoleService>();
            _authService = Program.GetService<IAuthService>();

            _currentStaff = _authService.GetAuthenticatedStaff();
            _store = _authService.GetStoreInfo();
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

        private void FrmManageRole_Load(object sender, EventArgs e)
        {
            LoadAllRole();
        }


        private void LoadAllRole () {
        
            try
            {
                _roles = _roleService.GetAllRoleByStoreId(_store.Id);

                List<object> dgRolesData = new List<object>();

                foreach (Role role in _roles)
                {
                    dgRolesData.Add(new 
                    {
                        role.Name,
                        role.Description,
                        role.CreatedAt,
                        role.UpdatedAt
                    });

                }

                dgRoles.DataSource = dgRolesData;

                dgRoles.Columns[0].HeaderText = "Tên vai trò";
                dgRoles.Columns[1].HeaderText = "Mô tả";
                dgRoles.Columns[2].HeaderText = "Thời gian tạo";
                dgRoles.Columns[3].HeaderText = "Cập nhật lần cuối";

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                  ex.GetBaseException().Message,
                  "Tải danh sách vai trò thất bại",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }


        private Role GetSelectedRole ()
        {
            if (dgRoles.SelectedRows.Count <= 0)
            {
                return null;
            }

            DataGridViewRow selectedRow = dgRoles.SelectedRows[0];

            string roleName = selectedRow?.Cells["Name"]?.Value?.ToString();

            if (roleName == null) return null;

            try
            {
                return _roles.FirstOrDefault(r => r.Name.Equals(roleName));
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        private void btnAddRole_Click(object sender, EventArgs e)
        {
            FrmAddRole frmAddRole = new FrmAddRole();

            frmAddRole.ShowDialog();

            LoadAllRole();
        }

        private void DeleteRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Bạn có chắc muốn xóa quyền này chứ ?",
              "Chú ý",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question
          );


            if (result == DialogResult.Cancel) return;
        }
    }
}
