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

namespace Toomeet_Pos.BLL
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;
        private readonly IRoleService _roleService;

        public ProductService (
            IProductRepository productRepository, 
            IRoleService roleService
        )
        {
            _productRepository = productRepository;
            _roleService = roleService;
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


    }
}
