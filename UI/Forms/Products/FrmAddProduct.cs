using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.BLL;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Products;
using Toomeet_Pos.UI.Validations;

namespace Toomeet_Pos.UI.Forms
{
    public partial class FrmAddProduct : Form
    {

        private readonly IAuthService _authService;
        private readonly IRoleService _roleService;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        private readonly IImageService _imageService;
        private readonly IProductValidate _productValidate;
        private readonly IProductService _productService;

        private Store _store;
        private Staff _currentStaff;


        private List<Category> _categories;
        private List<Brand> _brands;


        private Product _product;



        public FrmAddProduct()
        {
            InitializeComponent();

            _authService = Program.GetService<IAuthService>();
            _roleService = Program.GetService<IRoleService>();
            _brandService = Program.GetService<IBrandService>();
            _categoryService = Program.GetService<ICategoryService>();
            _imageService = Program.GetService<IImageService>();
            _productValidate = Program.GetService<IProductValidate>();
            _productService = Program.GetService<IProductService>(); 


            _currentStaff = _authService.GetAuthenticatedStaff();
            _store = _authService.GetStoreInfo();


            _product = new Product();

        }


        private void FrmAddProduc_Load(object sender, EventArgs e)
        {
            LoadAllBrand();
            LoadAllCategories();
        }


        private void LoadAllBrand ()
        {
            try
            {
                _brands = _brandService.GetAllBrands(_store.Id);
                cbBrands.Items.Clear();
                _brands.ForEach(b => cbBrands.Items.Add(b.Name));
                if (cbBrands.Items.Count > 0) cbBrands.SelectedIndex = 0;
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

        private void LoadAllCategories ()
        {
            try
            {
                _categories = _categoryService.GetAllCategories(_store.Id);
                cbCategories.Items.Clear();
                _categories.ForEach(c => cbCategories.Items.Add(c.Name));
                if (cbCategories.Items.Count > 0) cbCategories.SelectedIndex = 0;
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

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() != DialogResult.OK) return;

            string path = openFile.FileName;

            _product.Image = _imageService.ImageToByteArray(path);
            pictureBoxAvatar.Image = Image.FromFile(path);

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

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            string name = txtName.Value;

            ValidateResult nameValidate = _productValidate.IsValidName(name);


            if (nameValidate.IsError)
            {
                txtName.ErrorMessage = nameValidate.ErrorMessage;
                return;
            }

            string skucode = txtSkuCode.Value;

            ValidateResult skucodeValidate = _productValidate.IsValidSkuCode(skucode);


            if (skucodeValidate.IsError)
            {
                txtSkuCode.ErrorMessage = skucodeValidate.ErrorMessage;
                return;
            }


            string barcode = txtBarcode.Value;

            ValidateResult barcodeValidate = _productValidate.IsValidBarcode(barcode);


            if (barcodeValidate.IsError)
            {
                txtBarcode.ErrorMessage = barcodeValidate.ErrorMessage;
                return;
            }


            double weight = Convert.ToDouble(txtWeight.Value);


            ValidateResult weightValidate = _productValidate.IsValidWeight(weight);


            if (weightValidate.IsError)
            {
                txtWeight.ErrorMessage = weightValidate.ErrorMessage;
                return;
            }


            string unitOfMeasure = txtUnitOfMeasure.Value;

            ValidateResult unitOfMeasureValidate = _productValidate.IsValidUnitOfMeasure(unitOfMeasure);

            if (unitOfMeasureValidate.IsError)
            {
                txtUnitOfMeasure.ErrorMessage = unitOfMeasureValidate.ErrorMessage;
                return;
            }

            /// hande more validate here ........
            /// 

            double retailPrice = Convert.ToDouble(txtRetailPrice.Value);
            double purchasePrice = Convert.ToDouble(txtPurchasePrice.Value);
            double bulkPurchasePrice = Convert.ToDouble(txtBulkPurchasePrice.Value);
            double costPrice = Convert.ToDouble(txtCostPrice.Value);

            int inventoryQuantity = Convert.ToInt32(txtInventoryQuantity.Value);

            Category category = _categories[cbCategories.SelectedIndex];

            Brand brand = _brands[cbBrands.SelectedIndex];

            string desc = txtDescription.Value;


            _product.BarCode = barcode;
            _product.Brand = brand;
            _product.Store = _store;
            _product.SkuCode = skucode;
            _product.Status = ProductStatus.AVAILABLE;
            _product.BulkPurchasePrice = bulkPurchasePrice;
            _product.PurchasePrice = purchasePrice;
            _product.UnitOfMeasure = unitOfMeasure;
            _product.CostPrice = costPrice;
            _product.RetailPrice = retailPrice;
            _product.Category = category;
            _product.Weight = weight;
            _product.Description = desc; 
            _product.InventoryQuantity = inventoryQuantity;
            _product.Name = name;

            SaveProductDto dto = new SaveProductDto()
            {
                Product = _product,
                Staff = _currentStaff,
                Store = _store
            };

            btnAddNewProduct.Enabled = false;

            try
            {
                _productService.UpsertProduct(dto);
                Close();
            }
            catch (DbEntityValidationException ex)
            {
                // Truy cập vào các lỗi xác thực thực thể
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        // In ra thông báo lỗi của từng thuộc tính
                        Console.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }

                // Bắt lại ngoại lệ và xử lý tùy ý
                throw;
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                  ex.GetBaseException().Message,
                  "Tạo mới sản phẩm thất bại",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
              );
            }

            btnAddNewProduct.Enabled = true;

        }




        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FrmAddCategory frmAddCategory = new FrmAddCategory();

            frmAddCategory.ShowDialog();

            LoadAllCategories();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            FrmAddBrand frmAddBrand = new FrmAddBrand();

            frmAddBrand.ShowDialog();

            LoadAllBrand();
        }
    }
}
