using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.Entites.orders
{
    public class Order : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public double AmountGivenByCustomer { get; set; }

        public double Change { get; set; }

        public double CustomerDebt { get; set; }

        [Required]
        public Staff Staff { get; set; }

        public double Total { get; set; }

        public List<Product> Products { get; set; }

        [Required]
        public Store Store { get; set; }
    }
}
