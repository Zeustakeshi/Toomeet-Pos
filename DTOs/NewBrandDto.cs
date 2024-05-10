using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.DTOs
{
    public class NewBrandDto
    {
        public Brand Brand { get; set; }
        public Staff Staff { get; set; }
        public Store Store { get; set; }
    }
}
