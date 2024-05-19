using System;
using System.Collections.Generic;
using System.Diagnostics.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.DTOs;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.BLL.Interfaces
{
    public interface IProductService
    {

        Product UpsertProduct (SaveProductDto dto);

        Product GetProductByProductId(ProductId id);

        List<Product> GetAllProduct(long storeId);

        void DeleteProduct(Product product, Staff staff);

        List<Product> SearchProduct(string keyword);

        List<Product> GetExampleProducts();
    }
}
