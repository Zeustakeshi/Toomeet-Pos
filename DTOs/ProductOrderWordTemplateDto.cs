using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.DTOs
{
    public class ProductOrderWordTemplateDto
    {
        public string SkuCode { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }

        public string UnitOfMeasure { get; set; }

    }
}
