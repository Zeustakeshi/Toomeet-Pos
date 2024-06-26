﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.DAL.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductByProductId(ProductId id);

        Product SaveProduct(Product product);

        Product UpdateProduct (Product product);

        List<Product> GetAllProductByStoreId(long storeId);

        List<Product> GetProductByKeyword(string keyword);

        void DeleteProduct (Product product);


    }
}
