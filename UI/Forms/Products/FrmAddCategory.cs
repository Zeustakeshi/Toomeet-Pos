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
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.UI.Forms.Products
{
    public partial class FrmAddCategory : Form
    {
        private readonly Store _store;
        private readonly Staff _currentStaff;
        private readonly ICategoryService _categoryService;

        public FrmAddCategory(Store store, Staff staff)
        {
            InitializeComponent();

            _currentStaff = staff;
            _store = store;
            _categoryService = Program.GetService<ICategoryService>();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category()
                {
                    Name = txtCategoryName.Text,
                    Description = txtCategoryDescription.Text,
                    Store = _store,
                    StoreId = _store.Id
                };

                _categoryService.CreateCategory(new DTOs.NewCategoryDto()
                {
                    Store = _store,
                    Staff = _currentStaff,
                    Category = category
                });
                Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Thêm loại sản phẩm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoryDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
