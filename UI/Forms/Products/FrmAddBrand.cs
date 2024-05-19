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
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites.Products;
using Toomeet_Pos.Entites;
using Toomeet_Pos.UI.Validations;
using Toomeet_Pos.BLL.Interfaces;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmAddBrand : Form
    {

        private readonly IBrandValidate _brandValidate;
        private readonly IBrandService _brandService;
        private readonly IAuthService _authService;

        private Staff _currentStaff;
        private Store _store;

        public FrmAddBrand()
        {
            InitializeComponent();

            _brandService = Program.GetService<IBrandService>();
            _brandValidate = Program.GetService<IBrandValidate>();
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

        private void btnAddNewBrand_Click(object sender, EventArgs e)
        {
            string name = txtName.Value;

            ValidateResult nameValidate = _brandValidate.IsValidName(name);


            if (nameValidate.IsError)
            {
                txtName.ErrorMessage = nameValidate.ErrorMessage;
                return;
            }



            string desc = txtDesc.Value;

            ValidateResult descValidate = _brandValidate.IsValidDescription(desc);

            if (descValidate.IsError)
            {
                txtDesc.ErrorMessage = descValidate.ErrorMessage;
                return;
            }

            Brand brand = new Brand()
            {
                Name = name,
                Description = desc.Length > 0 ? desc : null
            };


            btnAddNewBrand.Enabled = false;
            try
            {
                _brandService.CreateBrand(
                    new SaveBrandDto ()
                    {
                        Brand = brand,
                        Staff = _currentStaff,
                        Store = _store
                    }
                );
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   ex.GetBaseException().Message,
                   "Tạo mới nhãn hiệu thất bại",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
            btnAddNewBrand.Enabled = true;
        }
    }
}
