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
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmAddStaff : Form
    {
        public FrmAddStaff()
        {
            InitializeComponent();
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

        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            FrmAddRole frmAddRole = new FrmAddRole();
            Hide();
            frmAddRole.ShowDialog();
            Show();
            LoadAllRole();
        }
    }
}
