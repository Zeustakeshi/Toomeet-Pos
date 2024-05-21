using System;
using System.Collections.Generic;
using System.Data.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.BLL.Interfaces;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.DAL.Repositories;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Products;
using Toomeet_Pos.UI.UC;

namespace Toomeet_Pos.BLL
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;
        private readonly IRoleService _roleService;
        private readonly IExcelService _excelService;

        public ProductService (
            IProductRepository productRepository, 
            IRoleService roleService,
            IExcelService excelService
        )
        {
            _productRepository = productRepository;
            _roleService = roleService;
            _excelService = excelService;
        }


        public List<Product> SearchProduct(string keyword)
        {
            return _productRepository.GetProductByKeyword(keyword.ToLower());
        }


        public void DeleteProduct (Product product, Staff staff)
        {
            if (!_roleService.CanDeleteProduct(staff))
            {
                throw new Exception("Bạn không có quyền xóa sản phẩm này");
            }

            Product existedProduct = GetProductByProductId(new ProductId()
            {
                SkuCode = product.SkuCode,
                StoreId = product.StoreId
            });


            if (existedProduct == null)
            {
                throw new Exception("Không tìm thấy sản phẩm này");
            }

             _productRepository.DeleteProduct(existedProduct);

        }

        public Product UpsertProduct(SaveProductDto dto)
        {

            Product product = dto.Product;
            Store store = dto.Store;
            Staff staff = dto.Staff;

            if (product == null || store == null || staff == null)
            {
                throw new Exception("Không đủ thông tin để cập nhật sản phẩm");
            }

            if (!_roleService.CanEditProduct(staff))
            {
                throw new Exception("Nhân viên " + staff.Name + " ko có quyền cập nhật sản phẩm");
            }


            ProductId productId = new ProductId()
            {
                SkuCode=product.SkuCode,
                StoreId= store.Id
            };

            Product existedProduct = _productRepository.GetProductByProductId(productId);

            if (existedProduct != null)
            {
                return UpdateProduct(dto);
            }else
            {
                return CreateProduct(dto);
            }

        }

        private Product UpdateProduct (SaveProductDto dto)
        {

            Product product = dto.Product;
            Store store = dto.Store;


            ProductId productId = new ProductId()
            {
                SkuCode = product.SkuCode,
                StoreId = store.Id
            };

            Product existedProduct = _productRepository.GetProductByProductId(productId);

            existedProduct.UpdateAll(dto.Product);

            return _productRepository.UpdateProduct(existedProduct);

        }


        private Product CreateProduct (SaveProductDto dto)
        {

            Product product = dto.Product;
            Staff createdStaff = dto.Staff;
            Store store = dto.Store;

            ProductId productId = new ProductId()
            {
                SkuCode = product.SkuCode,
                StoreId = store.Id
            };
            
            if (product == null || createdStaff == null || store == null)
            {
                throw new Exception("Không đủ thông tin để tạo sản phẩm này");
            }


            if (!_roleService.CanCreateProduct(createdStaff))
            {
                throw new Exception("Nhân viên " + createdStaff.Name + " Không có quyền tạo sản phẩm");
            }


            if (product.Store == null) product.Store = store;

            return _productRepository.SaveProduct(product);
        }

        public  Product GetProductByProductId (ProductId id)
        {
            return _productRepository.GetProductByProductId(id);
        }

        public List<Product> GetAllProduct (long storeId)
        {
            return _productRepository.GetAllProductByStoreId(storeId);
        }


        private bool IsExistedProduct (ProductId id)
        {
            return GetProductByProductId(id) != null;
        }

        public List<Product> GetExampleProducts ()
        {

            return new List<Product>()
            {
                new Product()
                {
                    Name = "Nước tăng lực Sting",
                    BarCode = "1924252526256",
                    Brand = new Brand ()
                    {
                        Name = "Sting",
                        Description = "Mô tả nhãn hiệu của nước tăng lực Sting ...."
                    },
                    InventoryQuantity = 100,
                    PurchasePrice = 100,
                    RetailPrice = 100,
                    CostPrice = 100,
                    SkuCode = "NC_TANG_LUC_STING",
                    UnitOfMeasure = "Chai",
                    Weight = 200,
                    BulkPurchasePrice = 100,
                    Description = "Mô tả sản phẩm ...",
                    Category = new Category()
                    {
                        Code = "NUOC_GIAI_KHAC_CO_GA",
                        Name = "Nước giải khát có ga",
                    }
                    ,    CreatedAt = new DateTime(2024, 2, 2),
                    UpdatedAt = new DateTime(2004, 2, 2),
                },

                new Product()
                {
                    Name = "Nước suối Lavie",
                    BarCode = "1924252526256",
                    Brand = new Brand ()
                    {
                        Name = "Lavie",
                        Description = "Mô tả nhãn hiệu của nước suối Lavie ...."
                    },
                    InventoryQuantity = 50,
                    PurchasePrice = 5000,
                    RetailPrice = 7000,
                    CostPrice = 5000,
                    SkuCode = "NS_LAVIE",
                    UnitOfMeasure = "Chai",
                    Weight = 500,
                    BulkPurchasePrice = 4500,
                    Description = "Mô tả sản phẩm ...",
                    Category = new Category()
                    {
                        Code = "NUOC_SUOI",
                        Name = "Nước suối"
                    }
                   ,    CreatedAt = new DateTime(2024, 2, 2),
                    UpdatedAt = new DateTime(2004, 2, 2),
                },

                new Product()
                {
                    Name = "Nước ngọt Coca-Cola",
                    BarCode = "1924252526256",
                    Brand = new Brand ()
                    {
                        Name = "Coca-Cola",
                        Description = "Mô tả nhãn hiệu của nước ngọt Coca-Cola ...."
                    },
                    InventoryQuantity = 20,
                    PurchasePrice = 8000,
                    RetailPrice = 10000,
                    CostPrice = 8000,
                    SkuCode = "NS_COCA",
                    UnitOfMeasure = "Chai",
                    Weight = 350,
                    BulkPurchasePrice = 7500,
                    Description = "Mô tả sản phẩm ...",
                    Category = new Category()
                    {
                        Code = "NUOC_NGOT_CO_GA",
                        Name = "Nước ngọt có ga"
                    }
                      ,    CreatedAt = new DateTime(2024, 2, 2),
                    UpdatedAt = new DateTime(2004, 2, 2),
                },

                new Product()
                {
                    Name = "Sữa tươi TH True Milk",
                    BarCode = "1924252526256",
                    Brand = new Brand ()
                    {
                        Name = "TH True Milk",
                        Description = "Mô tả nhãn hiệu của sữa tươi TH True Milk ...."
                    },
                    InventoryQuantity = 30,
                    PurchasePrice = 12000,
                    RetailPrice = 15000,
                    CostPrice = 12000,
                    SkuCode = "ST_TH",
                    UnitOfMeasure = "Hộp",
                    Weight = 1000,
                    BulkPurchasePrice = 11000,
                    Description = "Mô tả sản phẩm ...",
                    Category = new Category()
                    {
                        Code = "SUA_TUOI",
                        Name = "Sữa tươi"
                    }
                       ,    CreatedAt = new DateTime(2024, 2, 2),
                    UpdatedAt = new DateTime(2004, 2, 2),
                },
            };
        }
    }
}
