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
    public partial class FrmAddProduct2 : Form
    {

        private readonly Store _store;
        private readonly Staff _currentStaff;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        private List<Category> _categories;
        private List<Brand> _brands;

        public FrmAddProduct2(Store store, Staff staff)
        {
            InitializeComponent();
            _store = store;
            _currentStaff = staff;
            _productService = Program.GetService<IProductService>();
            _categoryService = Program.GetService<ICategoryService>();
            _brandService = Program.GetService<IBrandService>();
            _categories = new List<Category>();
            _brands = new List<Brand>();
        }
            
      

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadBrands();
        }


        private void LoadCategories()
        {
            _categories.Clear();
            cbCategory.Items.Clear();

            try
            {
                _categories = _categoryService.GetAllCategories(_store.Id);
                
                foreach (Category category in _categories)
                {
                    cbCategory.Items.Add(category.Name);
                }

                if (cbCategory.Items.Count > 0) cbCategory.SelectedIndex = 0;

           }catch (Exception ex)
           {
                MessageBox.Show(ex.GetBaseException().Message, "Tải loại sản phẩm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
           }
        }

        private void LoadBrands ()
        {
            _brands.Clear();
            cbBrand.Items.Clear();
            try
            {
                _brands = _brandService.GetAllBrands(_store.Id);
                foreach (Brand brand in _brands)
                {
                    cbBrand.Items.Add(brand.Name);
                }

                if (cbBrand.Items.Count > 0) cbBrand.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Tải thương hiệu thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Brand selectedBrand = _brands[cbBrand.SelectedIndex];
                Category selectedCategory = _categories[cbCategory.SelectedIndex];

                if (selectedCategory == null)
                {
                    throw new Exception("Vui lòng chọn loại sản phẩm");
                }

                if (selectedBrand == null)
                {
                    throw new Exception("Vui lòng chọn thương hiệu");
                }


                Product product = new Product()
                {
                    Name = txtProductName.Text,
                    BarCode = txtBarCode.Text,
                    SkuCode = txtSkuCode.Text,
                    Weight = Convert.ToDouble(txtWeight.Text),
                    RetailPrice = Convert.ToDouble(txtRetailPrice.Text),
                    BulkPurchasePrice = Convert.ToDouble(txtBulkPurchasePrice.Text),
                    PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text),
                    InventoryQuantity = Convert.ToInt32(txtInventoryQuantity.Text),
                    CostPrice = Convert.ToDouble(txtCostPrice.Text),
                    Brand = selectedBrand,
                    Category = selectedCategory,
                    Status = chbProductAvailable.Checked ? ProductStatus.AVAILABLE : ProductStatus.DAMAGED
                };

                Product newProduct = _productService.CreateProduct(new DTOs.NewProductDto()
                {
                    Product = product,
                    Staff = _currentStaff,
                    Store = _store
                });

                MessageBox.Show("Sản phẩm " + newProduct.Name + " đã được thêm vào cửa hàng", "Thêm Sản phẩm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Thêm sản phẩm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FrmAddCategory frmAddCategory = new FrmAddCategory(_store, _currentStaff);
            frmAddCategory.ShowDialog();
            LoadCategories();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            FrmAddBrand frmAddBrand = new FrmAddBrand(_store, _currentStaff);
            frmAddBrand.ShowDialog();
            LoadBrands();
        }
    }
}
