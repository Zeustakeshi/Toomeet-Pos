﻿using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toomeet_Pos.BLL;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.orders;
using Toomeet_Pos.Entites.Products;
using Toomeet_Pos.UI.UC;

namespace Toomeet_Pos.UI.Forms.Sales
{
    public partial class FrmSoldAtTheCounter : Form
    {

        private readonly IProductService _productService;
        private readonly IImageService _imageService;
        private readonly IWordService _wordService;
        private readonly IAuthService _authSerivce;
        private readonly IOrderService _orderService;


        private List<Product> _orderProducts;
        private double _totalBill;

        private Store _store;
        private Staff _currentStaff;

        public FrmSoldAtTheCounter()
        {
            InitializeComponent();
            _orderProducts = new List<Product>();
            _productService = Program.GetService<IProductService>();
            _imageService = Program.GetService<IImageService>();
            _wordService = Program.GetService<IWordService>();
            _authSerivce = Program.GetService<IAuthService>();
            _orderService = Program.GetService<IOrderService>();


            _store = _authSerivce.GetStoreInfo();
            _currentStaff = _authSerivce.GetAuthenticatedStaff();

            _totalBill = 0;
        }

        private void FrmSoldAtTheCounter_Load(object sender, EventArgs e)
        {
            lbCustomerName.Text = "Khách mua lẻ";
            lbTotalAmount.Text = "0";
            lbVAT.Text = "0";
            lbDiscount.Text = "0";
            lbOtherPayableAmount.Text = "0";
            lbChange.Text = "0";
            txtAmountGivenByCustomer.Text = "0";
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {

            string keyword = txtSearch.Text;

            if (keyword.Trim() == "") return;

            try
            {
                List<Product> searchProducts = new List<Product>();
                searchProducts = _productService.SearchProduct(keyword);

                if (searchProducts.Count <= 0)
                {
                    productSearchResults.Controls.Clear();
                    MessageBox.Show("Không tìm thấy kết quả");
                    return;
                }

                foreach (Product product in searchProducts)
                {
                    ProductSearchItem item = new ProductSearchItem();

                    item.ProductNameText = product.Name;
                    item.ProductCategoryText = product.Category.Name;
                    if (product.Image != null) item.ProductImage = _imageService.ByteArrayToImage(product.Image);
                    item.ProductSearchItemClick += (object _s, EventArgs _e) =>
                    {
                        _orderProducts.Add(product);
                        productSearchResults.Controls.Remove((ProductSearchItem)_s);
                        AddOrderProducts(product);
                        UpdateBill();

                    };
                    productSearchResults.Controls.Add(item);
                    item.Dock = DockStyle.Top;
                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        private void AddOrderProducts (Product product)
        {
            ProductOrderItem item = new ProductOrderItem();
            item.ProductNameLabel = product.Name;
            item.ProductCategoryLabel = product.Category.Name;
            item.SkuCode = product.SkuCode;
            item.Price = product.RetailPrice;
            item.Quantity = 1;
            item.MaxQuantity = product.InventoryQuantity;
            item.MinQuantity = 0;
            item.Dock = DockStyle.Top;
            item.UnitOfMeasure = product.UnitOfMeasure;

            item.OnQuantityChange += (object _s, EventArgs _e) =>
            {
                UpdateBill();
            };

            item.OnRemove += (object _s, EventArgs _e) =>
            {
                orderProductContaier.Controls.Remove(item);
                UpdateBill();
            };


            orderProductContaier.Controls.Add(item);

        }


        private void UpdateBill ()
        {
            _totalBill = 0;
            foreach (ProductOrderItem item in orderProductContaier.Controls)
            {
                _totalBill += item.TotalPrice;
            }

            lbOtherPayableAmount.Text = _totalBill.ToString();
            lbTotalAmount.Text = _totalBill.ToString();

            double amountGivenByCustomer = Convert.ToDouble(txtAmountGivenByCustomer.Text);

            if (amountGivenByCustomer < _totalBill)
            {
                lbCustomerDebt.Text = (_totalBill - amountGivenByCustomer).ToString();
                lbChange.Text = "0";
            }else if (_totalBill < amountGivenByCustomer)
            {
                lbChange.Text = (amountGivenByCustomer - _totalBill).ToString();
                lbCustomerDebt.Text = "0";
            }else
            {
                lbChange.Text = "0";
                lbCustomerDebt.Text = "0";
            }

        }

        private void txtAmountGivenByCustomer_TextChanged(object sender, EventArgs e)
        {
            UpdateBill();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _orderProducts.Clear();
            ResetBill();
            productSearchResults.Controls.Clear();

        }

        private void ResetBill ()
        {
            lbCustomerName.Text = "Khách mua lẻ";
            lbTotalAmount.Text = "0";
            lbVAT.Text = "0";
            lbDiscount.Text = "0";
            lbOtherPayableAmount.Text = "0";
            lbChange.Text = "0";
            txtAmountGivenByCustomer.Text = "0";
            orderProductContaier.Controls.Clear();
        }


        private void btnPayment_Click(object sender, EventArgs e)
        {

            Entites.orders.Order order = new Entites.orders.Order()
            {
                CustomerAddress = "",
                CustomerName = "khách mua lẻ",
                Change = Convert.ToDouble(lbChange.Text),
                AmountGivenByCustomer = Convert.ToDouble(txtAmountGivenByCustomer.Text),
                CustomerDebt = Convert.ToDouble(lbCustomerDebt.Text),
                Staff = _currentStaff,
                Store = _store,
                Total = _totalBill
            };


            List<OrderDetail> orderDetails = new List<OrderDetail>();

            List<ProductOrderWordTemplateDto> productTemplates = new List<ProductOrderWordTemplateDto>();

            foreach (ProductOrderItem item in orderProductContaier.Controls)
            {
                productTemplates.Add(new ProductOrderWordTemplateDto()
                {
                    Name = item.ProductNameLabel,
                    Amount = item.Quantity,
                    CategoryName = item.ProductCategoryLabel,
                    SkuCode = item.SkuCode,
                    TotalPrice = item.TotalPrice,
                    UnitOfMeasure = item.UnitOfMeasure
                });

                orderDetails.Add(new OrderDetail()
                {
                    Order = order,
                    Product = _orderProducts.FirstOrDefault(p => p.SkuCode.Equals(item.SkuCode)) ?? null,
                    Quantity = item.Quantity,
                    Total = item.TotalPrice,
                    VAT = 0
                });

            }


            try
            {
                SaveOrderDto dto = new SaveOrderDto()
                {
                    Order = order,
                    Staff = _currentStaff,
                    Store = _store

                };

                dto.Order.OrderDetails = orderDetails;

                Entites.orders.Order newOrder = _orderService.CreateOrder(dto);


              //  _orderService.SaveAllOrderDetails(orderDetails);

                if (cbExportBill.Checked)
                {
                    SaveFileDialog sf = new SaveFileDialog();
                    DialogResult result = sf.ShowDialog();

                    if (result != DialogResult.OK) return;
                    string templatesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "templates");
                    string templateFilePath = Path.Combine(templatesDirectory, "bao_cao_mau.docx");


                    _wordService.ExportFile(sf.FileName, templateFilePath, new
                    {
                        storeName = newOrder.Store.Name,
                        storeAddress = newOrder.Store.Address ?? "",
                        storePhone = newOrder.Store.Owner?.Phone ?? "",
                        customerName = newOrder.CustomerName,
                        customerAddress = newOrder.CustomerAddress,
                        orderId = newOrder.Id,

                        amountGivenByCustomer = newOrder.AmountGivenByCustomer.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + "VND",
                        change = newOrder.Change.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + "VND",
                        customerDebt = newOrder.CustomerDebt.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + "VND",


                        staffName = _currentStaff.Name,
                        staffPhone = _currentStaff.Phone,

                        product = productTemplates.ToArray(),
                        total = _totalBill.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + "VND"
                    });

                }

            

                MessageBox.Show("Thanh toán thành công", "Kết quả thành toán", MessageBoxButtons.OK, MessageBoxIcon.Information);


                _orderProducts.Clear();
                ResetBill();
                productSearchResults.Controls.Clear();
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
                MessageBox.Show(ex.GetBaseException().Message, "Xuất hóa đơn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

        }

        
    }
}
