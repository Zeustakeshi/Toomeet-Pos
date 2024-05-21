using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.BLL;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Products;
using Toomeet_Pos.UI.UC;

namespace Toomeet_Pos.UI.Forms.Products
{
    public partial class FrmManageProducts : Form
    {

        private readonly IProductService _productService;
        private readonly IAuthService _authService;
        private readonly IImageService _imageService;
        private readonly IExcelService _excelService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;

        private Staff _currentStaff;
        private Store _store;

        private List<Product> _products;

        public FrmManageProducts()
        {
            InitializeComponent();

            _authService = Program.GetService<IAuthService>();
            _productService = Program.GetService<IProductService>();
            _imageService = Program.GetService<IImageService>();
            _excelService = Program.GetService<IExcelService>();
            _categoryService = Program.GetService<ICategoryService>();
            _brandService = Program.GetService<IBrandService>();


            _currentStaff = _authService.GetAuthenticatedStaff();
            _store = _authService.GetStoreInfo();


            lbProductBrand.Text = "";
            lbProductCategory.Text = "";
            lbProductInventoryQuantity.Text = "";
            lbProductName.Text = "";
            lbProductRetailPrice.Text = "";
            lbProductSkucode.Text = "";
            lbProductUnitOfMeasure.Text = "";

        }



        private void FrmManageProducts_Load(object sender, EventArgs e)
        {
            LoadAllPoducts();

            
        }

        private void btnViewProductCategories_Click(object sender, EventArgs e)
        {
            FrmManageProductCategory frmManageProductCategory = new FrmManageProductCategory();
            frmManageProductCategory.ShowDialog();

            LoadAllPoducts();
        }

        private void LoadAllPoducts()
        {
            try
            {
                List<Product> products = _productService.GetAllProduct(_store.Id);
                UpdateDgProduct(products);

                if (dgProducts.RowCount <= 0)
                {
                    btnViewProductDetail.Visible = false;
                    btnDelete.Visible = false;
                }else
                {
                    btnViewProductDetail.Visible = true;
                    btnDelete.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message,
                    "Tải danh sách sản phẩm thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void UpdateDgProduct(List<Product> products)
        {
            _products = products;

            List<object> dgProductData = new List<object>();

            foreach (Product product in _products)
            {


                dgProductData.Add(new
                {
                    product.SkuCode,
                    product.BarCode,
                    product.Name,
                    Brand = product.Brand.Name,
                    Category = product.Category.Name,
                    product.InventoryQuantity,
                    product.CreatedAt,
                    product.UpdatedAt
                });
            }


            dgProducts.DataSource = dgProductData;

            if (dgProducts.DataGridView.Rows.Count <= 0)
            {
                Controls.Add(btnAddProduct2);
                btnAddProduct2.Visible = true;
                return;
            }

            Controls.Remove(btnAddProduct2);
            btnAddProduct2.Visible = false;

            dgProducts.ColumnHeaderTexts = new List<string>()
            {
                "Mã sản phẩm",
                "BarCode",
                "Tên sản phẩm",
                "Thương hiệu",
                "Loại sản phẩm",
                "Tồn kho",
                "Ngày tạo",
                "Cập nhật lần cuối"
            };

            dgProducts.DataGridView.Rows[0].Selected = true;

            LoadSelectedProduct();
        }


        private Product GetSelectedProduct()
        {

            if (dgProducts.DataGridView.SelectedRows.Count <= 0)
            {
                return null;
            }

            DataGridViewRow selectedRow = dgProducts.DataGridView.SelectedRows[0];

            string skucode = selectedRow?.Cells["SkuCode"]?.Value?.ToString();

            if (skucode == null) return null;

            try
            {
                return _products.FirstOrDefault(p => p.SkuCode.Equals(skucode));
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        private void LoadSelectedProduct()
        {
            Product selectedProduct = GetSelectedProduct();

            if (selectedProduct == null) return;

            lbProductName.Text = selectedProduct.Name;
            lbProductSkucode.Text = selectedProduct.SkuCode;
            lbProductInventoryQuantity.Text = selectedProduct.InventoryQuantity.ToString();
            lbProductBrand.Text = selectedProduct.Brand.Name;
            lbProductCategory.Text = selectedProduct.Category.Name;
            lbProductRetailPrice.Text = selectedProduct.RetailPrice.ToString();
            lbProductUnitOfMeasure.Text = selectedProduct.UnitOfMeasure?.ToString();
            txtProductDesc.Value = selectedProduct.Description;
            if (selectedProduct.Image != null) pictureBoxAvatar.Image = _imageService.ByteArrayToImage(selectedProduct.Image);
            else pictureBoxAvatar.Image = pictureBoxAvatar.ErrorImage;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new FrmAddProduct();
            frmAddProduct.ShowDialog();

            LoadAllPoducts();
        }


        private void dgProducts_CellClick(object sender, EventArgs e)
        {
            LoadSelectedProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc muốn xóa sản phẩm này không",
                "Cảnh báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Cancel) return;

            Product selectedProduct = GetSelectedProduct();

            if (selectedProduct == null) return;

            try
            {
                _productService.DeleteProduct(selectedProduct, _currentStaff);
                LoadAllPoducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                ex.GetBaseException().Message,
                "Xóa sản phẩm thất bại",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (keyword.Trim() == "")
            {
                LoadAllPoducts();
            }

            try
            {
                List<Product> products = _productService.SearchProduct(keyword);
                UpdateDgProduct(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message,
                    "Không tìm thấy sản phẩm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void llbViewExampleProductFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "File excel sản phẩm mẫu";
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
            saveFileDialog.FileName = saveFileDialog.FileName + "Toomeet_mau_nhap_san_pham";

            DialogResult saveFileResult = saveFileDialog.ShowDialog();
           

            if (saveFileResult != DialogResult.OK) return;

            try
            {
               

                List<ProductExcelDto> exampleProducts = new List<ProductExcelDto>();

                foreach (Product pd in _productService.GetExampleProducts())
                {
                    exampleProducts.Add(ProductExcelDto.BuildFromProduct(pd));
                }

                CustomDataGridView dgExampleProduct = new CustomDataGridView
                {
                    DataSource = exampleProducts
                };

                dgExampleProduct.ColumnHeaderTexts = new List<string>()
                {
                    "Mã sản phẩm",
                    "Tên sản phẩm",
                    "BarCode",
                    "Mô tả",
                    "Đơn vị tính",
                    "Cân nặng",
                    "Thương hiệu",
                    "Loại sản phẩm",
                    "Giá bán lẻ",
                    "Giá bán số lượng lớn",
                    "Giá nhập hàng",
                    "Giá vốn",
                    "Số lượng tồn kho",
                    "Ngày tạo",
                    "Cập nhật lần cuối"
                };
                

                _excelService.ExportExcelFile(saveFileDialog.FileName, "Danh sách sản phẩm", dgExampleProduct);

                MessageBox.Show(
                  "Xuất file thành công",
                  "Thành công",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
              );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message,
                    "Xuất file sản phẩm mẫu thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
               
        }

        private void btnExportProductFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "File excel sản phẩm";
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
            saveFileDialog.FileName = saveFileDialog.FileName + "Toomeet_san_pham";

            DialogResult saveFileResult = saveFileDialog.ShowDialog();

            if (saveFileResult != DialogResult.OK) return;


            try
            {

                List<ProductExcelDto> exampleProducts = new List<ProductExcelDto>();

                foreach (Product pd in _products)
                {
                    exampleProducts.Add(ProductExcelDto.BuildFromProduct(pd));
                }

                CustomDataGridView dgExampleProduct = new CustomDataGridView
                {
                    DataSource = exampleProducts
                };

                dgExampleProduct.ColumnHeaderTexts = new List<string>()
                {
                    "Mã sản phẩm",
                    "Tên sản phẩm",
                    "BarCode",
                    "Mô tả",
                    "Đơn vị tính",
                    "Cân nặng",
                    "Thương hiệu",
                    "Loại sản phẩm",
                    "Giá bán lẻ",
                    "Giá bán số lượng lớn",
                    "Giá nhập hàng",
                    "Giá vốn",
                    "Số lượng tồn kho",
                    "Ngày tạo",
                    "Cập nhật lần cuối"
                };


                _excelService.ExportExcelFile(saveFileDialog.FileName, "Danh sách sản phẩm", dgExampleProduct);

                MessageBox.Show(
                  "Xuất file thành công",
                  "Thành công",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
              );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.GetBaseException().Message,
                    "Xuất file sản phẩm mẫu thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void btnUploadProductFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "File excel sản phẩm";
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
        
            DialogResult openFileResult = openFileDialog.ShowDialog();

            if (openFileResult != DialogResult.OK) return;

            try
            {

                DataTable dtProducts =  _excelService.ImportExcelFile(openFileDialog.FileName);
                _products.Clear();


                foreach (DataRow row in dtProducts.Rows)
                {

                    Brand brand = new Brand()
                    {
                        Name = row["Thương hiệu"].ToString(),
                        Store = _store,
                        StoreId = _store.Id,
                    };


                  

                    Category category = new Category()
                    {
                        Name = row["Loại sản phẩm"].ToString(),
                        Store = _store,
                        StoreId = _store.Id,
                    };

                 

                    Product product = new Product
                    {
                        SkuCode = row["Mã sản phẩm"].ToString(),
                        Name = row["Tên sản phẩm"].ToString(),
                        BarCode = row["BarCode"].ToString(),
                        Description = row["Mô tả"].ToString(),
                        UnitOfMeasure = row["Đơn vị tính"].ToString(),
                        Weight = Convert.ToInt32(row["Cân nặng"]),
                        Brand = _brandService.UpsertBrand(new SaveBrandDto()
                        {
                            Brand = brand,
                            Staff = _currentStaff,
                            Store = _store
                        }),
                        Category = _categoryService.UpsertCategory(new SaveCategoryDto()
                        {
                            Category = category,
                            Staff = _currentStaff,
                            Store = _store,
                        }),
                        RetailPrice = Convert.ToDouble(row["Giá bán lẻ"]),
                        BulkPurchasePrice = Convert.ToDouble(row["Giá bán số lượng lớn"]),
                        PurchasePrice = Convert.ToDouble(row["Giá nhập hàng"]),
                        CostPrice = Convert.ToDouble(row["Giá vốn"]),
                        InventoryQuantity = Convert.ToInt32(row["Số lượng tồn kho"]),
                        CreatedAt = DateTime.Parse(row["Ngày tạo"].ToString()),
                        UpdatedAt = DateTime.Parse(row["Cập nhật lần cuối"].ToString())
                    };

                    _productService.UpsertProduct(new SaveProductDto() { 
                        Product = product,
                        Store = _store,
                        Staff= _currentStaff,
                    });

                    _products.Add(product);

                }

                
                UpdateDgProduct(_products);
                
                

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
                   "Nhập file sản phẩm thất bại",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );

                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() != DialogResult.OK) return;

            string path = openFile.FileName;


            try
            {
                Product selectedProduct = GetSelectedProduct();
                if (selectedProduct == null)
                {
                    throw new Exception("Không có sản phẩm nào chọn");
                }

                selectedProduct.Image = _imageService.ImageToByteArray(path);
                _productService.UpsertProduct(new SaveProductDto()
                {
                    Product= selectedProduct,
                    Store = _store,
                    Staff = _currentStaff
                });
                pictureBoxAvatar.Image = Image.FromFile(path);

                MessageBox.Show(
                   "Ảnh đã tải lên thành công",
                   "Cập nhật sản phẩm thành công",
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
    }
}
