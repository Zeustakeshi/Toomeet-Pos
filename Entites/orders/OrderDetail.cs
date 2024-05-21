using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.Entites.orders
{
    public class OrderDetail : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public Order Order { get; set; }

        [Required]
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int VAT { get; set; }

        public double Total { get; set; }
    }
}
