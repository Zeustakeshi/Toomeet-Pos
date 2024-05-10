using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DAL.Interfaces;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private AppDBContext _db;

        public ProductRepository (IDataAccessLayer dataAccess)
        {
            _db = dataAccess.GetContext();
        }

        public Product GetProductByProductId(ProductId productId)
        {
            return _db.Product.FirstOrDefault(
                p => p.StoreId.Equals(productId.StoreId) && 
                     p.SkuCode.Equals(productId.SkuCode)
                );
        }

        public Product SaveProduct(Product product)
        {
            Product newProduct = _db.Product.Add(product);
            _db.SaveChanges();
            return newProduct;
        }

        public List<Product> GetAllProductByStoreId(long storeId)
        {
            return _db.Product
                .Where(p => p.StoreId.Equals(storeId)).ToList();
        }

    }
}
