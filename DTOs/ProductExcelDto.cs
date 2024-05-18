using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.DTOs
{
    public class ProductExcelDto
    {
        public string SkuCode { get; set; }
        public string Name { get; set; }

        public string BarCode { get; set; }

        public string Description { get; set; }

        public string UnitOfMeasure { get; set; }

        public double Weight { get; set; }

        public string BrandName { get; set; }

        public string CategoryName { get; set; }

        public double RetailPrice { get; set; }

        public double BulkPurchasePrice { get; set; }

        public double PurchasePrice { get; set; }

        public double CostPrice { get; set; }

        public int InventoryQuantity { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }


        public static ProductExcelDto BuildFromProduct (Product product)
        {
            return new ProductExcelDto
            {
                SkuCode = product.SkuCode,
                Name = product.Name,
                BarCode = product.BarCode,
                Description = product.Description,
                UnitOfMeasure = product.UnitOfMeasure,
                Weight = product.Weight,
                BrandName = product.Brand.Name,
                CategoryName = product.Category.Name,
                RetailPrice = product.RetailPrice,
                BulkPurchasePrice = product.BulkPurchasePrice,
                PurchasePrice = product.PurchasePrice,
                CostPrice = product.CostPrice,
                InventoryQuantity = product.InventoryQuantity,
                CreatedAt = product.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"),
                UpdatedAt = product.UpdatedAt.ToString("yyyy-MM-dd HH:mm:ss"),
            };
        }

    }



}
