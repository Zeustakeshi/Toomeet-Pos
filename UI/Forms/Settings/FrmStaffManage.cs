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
using Toomeet_Pos.UI.Forms.Staffs;

namespace Toomeet_Pos.UI.Forms.settings
{
    public partial class FrmStaffManage : Form
    {
        private Staff _currentStaff;
        private readonly IStaffService _staffService;
        private readonly IRoleService _roleService;
       

        public FrmStaffManage(Staff staff)
        {
            InitializeComponent();
            _currentStaff = staff;
            _staffService = Program.GetService<IStaffService>();
            _roleService = Program.GetService<IRoleService>();
        }

        private void FrmStaffManage_Load(object sender, EventArgs e)
        {
            CheckCanAddStaff();
            LoadAllStaff();
        }

        private void LoadAllStaff ()
        {
            List<Staff> staffs = _staffService.GetAllStaffByStoreId(_currentStaff.WorkplaceId);
            dataGridStaffList.DataSource = staffs;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            FrmAddStaff2 frmAddStaff = new FrmAddStaff2(_currentStaff.Workplace, _currentStaff);
            Hide();
            frmAddStaff.ShowDialog();
            Show();
            LoadAllStaff();
        }

        private void CheckCanAddStaff ()
        {
            if (!_roleService.CanCreateStaff(_currentStaff))
            {
                btnAddStaff.Enabled = false;
                btnAddStaff.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            if (keyword == "")
            {
                LoadAllStaff();
            }

            try
            {
                dataGridStaffList.DataSource = _staffService.SearchStaff(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
