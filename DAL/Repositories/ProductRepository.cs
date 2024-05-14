using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Where(p => p.StoreId.Equals(storeId)).ToList();
        }


        public List<Product> GetProductByKeyword(string keyword)
        {
            return _db
                .Product
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Where(p =>
                p.Name.ToLower().Contains(keyword) ||
                p.SkuCode.ToLower().Contains(keyword) ||
                p.BarCode.ToLower().Contains(keyword)
            ).ToList();
        }


        public void DeleteProduct(Product product) {
            _db.Product.Remove(product);
            _db.SaveChanges();
        }
    }
}
