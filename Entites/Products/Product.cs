using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.Entites.Products
{
    public class Product : BaseEntity
    {


        [Key, Column(Order = 1)]
        public string SkuCode { get; set; }

        [Key, Column(Order = 2)]
        public long StoreId { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        [MinLength(13)]
        [MaxLength(13)]
        public string BarCode { get; set; }

        public string UnitOfMeasure { get; set; }

        [Range(0.1, double.MaxValue)]
        public double Weight { get; set; }

        [Range(0.1, double.MaxValue)]
        public double RetailPrice { get; set; }

        [Range(0.1, double.MaxValue)]
        public double BulkPurchasePrice  { get; set; }

        [Required]
        [Range(0.1, double.MaxValue)]
        public double PurchasePrice { get; set; }

        public string Image { get; set; }

        [Required]
        [Range(0.1, double.MaxValue)]
        public double CostPrice { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int InventoryQuantity { get; set; }

        public string CustomAttribute1 { get; set; }
        public string CustomAttribute2 { get; set; }
        public string CustomAttribute3 { get; set; }


        [Required]
        public Category Category { get; set; }


        public Brand Brand { get; set; }

        [Required]
        public ProductStatus Status { get; set; }

        public string Description { get; set; }

        [Required]
        [ForeignKey("StoreId")]
        public Store Store { get; set; }

    }

    public enum ProductStatus
    {
        AVAILABLE,
        OUT_OF_STOCK,
        DAMAGED
    }

    public class ProductId
    {
        public long StoreId { get; set; }
        public string SkuCode { get; set; }
    }
}
