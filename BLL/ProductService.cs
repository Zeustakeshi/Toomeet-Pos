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


        public Product CreateProduct (NewProductDto dto)
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


            if (IsExistedProduct(productId))
            {
                throw new Exception("Mã sản phẩm đã tồn tại trong cửa hàng");
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
                                
                }
            };
        }
    }
}
