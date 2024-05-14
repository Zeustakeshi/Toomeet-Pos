using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.Entites;
using Toomeet_Pos.UI.Validations;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmManageStaff : Form
    {


        private Staff _currentStaff;

        private List<Staff> _staffs;

        private readonly Store _store;
        private readonly IStaffService _staffService;
        private readonly IAuthService _authService;
        private readonly IImageService _imageService;
        private readonly IStaffValidate _staffValidate;


        public FrmManageStaff()
        {
            InitializeComponent();
            _authService = Program.GetService<IAuthService>();
            _staffService = Program.GetService<IStaffService>();
            _imageService = Program.GetService<IImageService>();
            _staffValidate = Program.GetService<IStaffValidate>();


            _currentStaff = _authService.GetAuthenticatedStaff();
            _store = _authService.GetStoreInfo();
        }

      
        private void FrmManageStaff_Load(object sender, EventArgs e)
        {

            lbDescError.Text = "";
            LoadAllStaff();
        }


        private void UpdateDgStaff (List<Staff> staffs)
        {

            _staffs = staffs;

            List<object> dgStaffData = new List<object>();

            foreach (Staff staff in _staffs)
            {
                string gender = "Khác";

                if (staff.Gender.Equals(StaffGender.FEMALE)) gender = "Nữ";
                if (staff.Gender.Equals(StaffGender.MALE)) gender = "Nam";

                string status = "Chưa bắt đầu";

                if (staff.Status.Equals(StaffStatus.WORKING)) status = "Đang làm việc";
                if (staff.Status.Equals(StaffStatus.RESIGNED)) status = "Nghỉ việc";

                dgStaffData.Add(new
                {
                    staff.Id,
                    staff.Name,
                    staff.Phone,
                    Gender = gender,
                    Status = status,
                    Role = staff.Role.Name,
                });
            }

            if (dgStaffData.Count <= 0)
            {
                Controls.Add(btnAddStaff2);
                btnAddStaff2.Visible = true;
            }else
            {
                Controls.Remove(btnAddStaff2);
                btnAddStaff2.Visible = false;

            }

            dgStaffList.DataSource = dgStaffData;

            if (dgStaffList.DataGridView.Rows.Count < 0)
            {
                return;
            }

            dgStaffList.ColumnHeaderTexts = new List<string>()
            {
                "Mã nhân viên",
                "Họ và tên",
                "Số điện thoại",
                "Giới tính",
                "Trạng thái",
                "Vai trò"
            };
            
            dgStaffList.DataGridView.Rows[0].Selected = true;

            LoadSelectedStaffInfo();
        }


        private void LoadAllStaff ()
        {
            try
            {
                List<Staff> staffs = _staffService.GetAllStaffByStoreId(_store.Id);
                UpdateDgStaff(staffs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message,
                    "Tải danh sách nhân viên thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void LoadSelectedStaffInfo ()
        {


            Staff selectedStaff = GetSelectedStaff();

            if (selectedStaff == null) return;


            if (selectedStaff.Status.Equals(StaffStatus.RESIGNED))
            {
                btnDismissal.Visible = false;
            }else
            {
                btnDismissal.Visible = true;
            }


            string gender = "Khác";

            if (selectedStaff.Gender.Equals(StaffGender.FEMALE)) gender = "Nữ";
            if (selectedStaff.Gender.Equals(StaffGender.MALE)) gender = "Nam";

            string status = "Chưa bắt đầu";

            if (selectedStaff.Status.Equals(StaffStatus.WORKING)) status = "Đang làm việc";
            if (selectedStaff.Status.Equals(StaffStatus.RESIGNED)) status = "Nghỉ việc";

            DateTime today = DateTime.Today;
            int age = today.Year - selectedStaff.Birthday.Year;


            lbName.Text = selectedStaff.Name;
            lbGender.Text = gender;
            lbAge.Text = age.ToString();
            lbPhone.Text = selectedStaff.Phone;
            lbStatus.Text = status;

            if (selectedStaff.Photo == null)
            {
                pictureBoxAvatar.Image = pictureBoxAvatar.ErrorImage;
            }
            else
            {
                pictureBoxAvatar.Image = _imageService.ByteArrayToImage(selectedStaff.Photo);
            }

            txtDesc.Text = selectedStaff.Description;


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

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            FrmAddStaff frmAddStaff = new FrmAddStaff();
            frmAddStaff.ShowDialog();
            LoadAllStaff();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() != DialogResult.OK) return;

            string path = openFile.FileName;


            try
            {
                Staff selectedStaff = GetSelectedStaff();
                if (selectedStaff == null)
                {
                    throw new Exception("Không có nhân viên nào được chọn");
                }

                selectedStaff.Photo = _imageService.ImageToByteArray(path);
                _staffService.UpdateStaff(selectedStaff);
                pictureBoxAvatar.Image = System.Drawing.Image.FromFile(path);

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


        private Staff GetSelectedStaff ()
        {
            if (dgStaffList.DataGridView.SelectedRows.Count <= 0)
            {
                return null; 
            }

            DataGridViewRow selectedRow = dgStaffList.DataGridView.SelectedRows[0];

            string staffId = selectedRow?.Cells["Id"]?.Value?.ToString();

            if (staffId == null) return null;

            try
            {
                return _staffs.FirstOrDefault(s => s.Id.Equals(Convert.ToInt64(staffId)));
            }
            catch (Exception ex)
            {
                return null; 
            }

        }

  
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string desc = txtDesc.Text;


            if (desc.Length <= 0 || desc == "") return;

            ValidateResult descValidate = _staffValidate.IsValidDescription(desc);

            if (descValidate.IsError)
            {
                lbDescError.Text = descValidate.ErrorMessage;
                txtDesc.Focus();
                return;
            }

            Staff selectedStaff = GetSelectedStaff();

            if (selectedStaff == null)
            {
                return;
            }

            btnUpdate.Enabled = false;

            try
            {
                selectedStaff.Description = desc;
                _staffService.UpdateStaff(selectedStaff);

                MessageBox.Show(
                  "Thông tin nhân viên đã được cập nhật",
                  "Cập nhật thành công",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
              );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message,
                    "Cập nhật thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            btnUpdate.Enabled = true;
          
        }

        private void btnDismissal_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn cho nhân viên này nghỉ việc ?",
                "Chú ý",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );


            if (result == DialogResult.Cancel) return;


            Staff selectedStaff = GetSelectedStaff();

            if (selectedStaff == null) return;
           
            selectedStaff.Status = StaffStatus.RESIGNED;

            btnDismissal.Enabled = false;

            try
            {
                _staffService.UpdateStaff(selectedStaff);

                MessageBox.Show(
                    "Thông tin nhân viên đã được cập nhật",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadAllStaff();

            }catch (Exception ex)
            {
                MessageBox.Show(
                   ex.GetBaseException().Message,
                   "Cập nhật thất bại",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
            btnDismissal.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            try
            {
                List<Staff> staffs = _staffService.SearchStaff(keyword);
                if (staffs.Count <= 0)
                {
                    LoadAllStaff();
                    return;
                }
                UpdateDgStaff(staffs);
            }catch (Exception ex)
            {
                MessageBox.Show(
                   ex.GetBaseException().Message,
                   "Tìm kiếm thất bại",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }

        }

        private void btnViewRoles_Click(object sender, EventArgs e)
        {
            FrmManageRole frmManageRole = new FrmManageRole();

            Hide();
            frmManageRole.ShowDialog();
            Show();
        }

        private void dgStaffList_CellClick(object sender, EventArgs e)
        {
            LoadSelectedStaffInfo();
        }
    }
}
