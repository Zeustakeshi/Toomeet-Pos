using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.DTOs
{
    public class SaveCategoryDto
    {
        public Staff Staff { get; set; }
        public Store Store { get; set; }
        public Category Category { get; set; }
    }
}
