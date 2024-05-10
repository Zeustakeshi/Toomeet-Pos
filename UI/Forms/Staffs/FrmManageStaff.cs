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

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmManageStaff : Form
    {


        private Staff _currentStaff;
        private readonly Store _store;
        private readonly IStaffService _staffService;
        private readonly IAuthService _authService;

        public FrmManageStaff()
        {
            InitializeComponent();
            _authService = Program.GetService<IAuthService>();
            _staffService = Program.GetService<IStaffService>();

            _currentStaff = _authService.GetAuthenticatedStaff();
            _store = _authService.GetStoreInfo();
        }

      
        private void FrmManageStaff_Load(object sender, EventArgs e)
        {
            LoadAllStaff();



        }


        private void LoadAllStaff ()
        {
            List<Staff> staffs = _staffService.GetAllStaffByStoreId(_store.Id);

            dgStaffList.DataSource = staffs;


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
    }
}
