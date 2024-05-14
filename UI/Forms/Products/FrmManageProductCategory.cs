using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Toomeet_Pos.BLL;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Products;
using Toomeet_Pos.UI.Validations;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmManageProductCategory : Form
    {
        private readonly ICategoryValidate _categoryValidate;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IAuthService _authService;
        private Staff _currentStaff;
        private Store _store;

        private List<Category> _categories;

        public FrmManageProductCategory()
        {
            InitializeComponent();

            _categoryService = Program.GetService<ICategoryService>();
            _productService = Program.GetService<IProductService>();
            _authService = Program.GetService<IAuthService>();
            _categoryValidate = Program.GetService<ICategoryValidate>();

            _currentStaff = _authService.GetAuthenticatedStaff();
            _store = _authService.GetStoreInfo();

        }



        private void FrmManageProductCategory_Load(object sender, EventArgs e)
        {
            LoadAllProductCategory();
        }

        

        private void LoadAllProductCategory ()
        {
            try
            {
                List<Category> categrories = _categoryService.GetAllCategories(_store.Id);
                UpdateDgCategrory(categrories);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message,
                    "Tải danh sách loại sản phẩm thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void UpdateDgCategrory(List<Category> categories)
        {
            _categories = categories;

            List<object> dgCategoriesData = new List<object>();

            foreach (Category category in _categories)
            {
                dgCategoriesData.Add(new
                {
                    category.Name,
                    category.Code,
                    category.Description,
                    category.CreatedAt
                });
            }

            dgCategories.DataSource = dgCategoriesData;





            if (dgCategories.DataGridView.Rows.Count <= 0) return;


            dgCategories.ColumnHeaderTexts = new List<string>()
            {
                "Tên loại sản phẩm",
                "Mã loại",
                "Ghi chú",
                "Ngày tạo"
            };


            LoadSelectedCategoryInfo();

        }

        private Category GetSelectedCategory ()
        {
            if (dgCategories.DataGridView.SelectedRows.Count <= 0)
            {
                return null;
            }

            DataGridViewRow selectedRow = dgCategories.DataGridView.SelectedRows[0];

            string categoryId = selectedRow?.Cells["Code"]?.Value?.ToString();

            if (categoryId == null) return null;

            try
            {
                return _categories.FirstOrDefault(c => c.Code.Equals(categoryId));
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        private void LoadSelectedCategoryInfo ()
        {

            Category selectedCategory = GetSelectedCategory();

            if (selectedCategory == null) return;

            txtCategoryName.Value = selectedCategory.Name;
            txtCategoryId.Value = selectedCategory.Code;
            txtCategoryDesc.Value = selectedCategory.Description;

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

        private void btnSave_Click(object sender, EventArgs e)
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

         
        

         

            btnSave.Enabled = false;
            try
            {

             

                SaveCategoryDto dto = new SaveCategoryDto()
                {
                    Staff = _currentStaff,
                    Store = _store,
                    Category = new Category()
                    {
                        Name= name,
                        Code = id,
                        Description = desc
                    }
                };


                _categoryService.UpsertCategory(dto);


                LoadAllProductCategory();
            }
            catch( Exception ex) {
                MessageBox.Show(
                   ex.GetBaseException().Message,
                   "Lưu thất bại",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
            btnSave.Enabled = true;

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Khi xóa loại sản phẩm, tất cả sản phẩm có liên quan sẽ bị xóa theo, bạn vẫn muốn xóa?",
                "Cảnh báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Cancel) return;

            string id = txtCategoryId.Value;

            ValidateResult idValidate = _categoryValidate.IsValidId(id);

            if (idValidate.IsError)
            {
                txtCategoryId.ErrorMessage = idValidate.ErrorMessage;
                return;
            }

            btnDelete.Enabled = false;
            try
            {
                _categoryService.DeleteCategoryByCodeAndStoreId(id, _store.Id);
                LoadAllProductCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   ex.GetBaseException().Message,
                   "Lưu thất bại",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
            btnDelete.Enabled = true;
        }

        private void txtCategoryName_ValueChange(object sender, EventArgs e)
        {
            string name = txtCategoryName.Value;

            ValidateResult nameValidate = _categoryValidate.IsValidName(name);


            if (nameValidate.IsError)
            {
                txtCategoryName.ErrorMessage = nameValidate.ErrorMessage;
                return;
            }
            txtCategoryName.ErrorMessage = "";
        }

        private void txtCategoryId_ValueChange(object sender, EventArgs e)
        {
            string id = txtCategoryId.Value;

            ValidateResult idValidate = _categoryValidate.IsValidId(id);

            if (idValidate.IsError)
            {
                txtCategoryId.ErrorMessage = idValidate.ErrorMessage;
                return;
            }

            txtCategoryId.ErrorMessage = "";



        }

        private void txtCategoryDesc_ValueChange(object sender, EventArgs e)
        {

            string desc = txtCategoryDesc.Value;

            ValidateResult descValidate = _categoryValidate.IsValidDescription(desc);

            if (descValidate.IsError)
            {
                txtCategoryDesc.ErrorMessage = descValidate.ErrorMessage;
                return;
            }
            txtCategoryDesc.ErrorMessage = "";
        }



        private void dgCategories_CellClick(object sender, EventArgs e)
        {
            LoadSelectedCategoryInfo();
        }
    }
}
