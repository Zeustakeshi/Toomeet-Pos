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
    public partial class FrmAddCategory : Form
    {

        private readonly ICategoryValidate _categoryValidate;
        private readonly ICategoryService _categoryService;
        private readonly IAuthService _authService;

        private Staff _currentStaff;
        private Store _store;

        public FrmAddCategory()
        {
            InitializeComponent();

            _categoryService = Program.GetService<ICategoryService>();
            _categoryValidate = Program.GetService<ICategoryValidate>();
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

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Value;

            ValidateResult nameValidate = _categoryValidate.IsValidName(name);


            if (nameValidate.IsError)
            {
                txtCategoryName.ErrorMessage = nameValidate.ErrorMessage;
                return;
            }


            string id = txtCategoryId.Value;

            ValidateResult idValidate = _categoryValidate.IsValidId(id);

            if (idValidate.IsError)
            {
                txtCategoryId.ErrorMessage = idValidate.ErrorMessage;
                return;
            }


            string desc = txtCategoryDesc.Value;

            ValidateResult descValidate = _categoryValidate.IsValidDescription(desc);

            if (descValidate.IsError)
            {
                txtCategoryDesc.ErrorMessage = descValidate.ErrorMessage;
                return;
            }

            Category category = new Category()
            {
                Code = id,
                Name = name,
                Description = desc.Length > 0 ? desc : null
            };
            btnAddNewCategory.Enabled = false;
            try
            {
                _categoryService.UpsertCategory(

                    new SaveCategoryDto()
                    {
                        Category = category,
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
                   "Tạo mới loại sản phẩm thất bại",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
            btnAddNewCategory.Enabled = true;
        }
    }
}
