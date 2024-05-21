using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.orders;

namespace Toomeet_Pos.DTOs
{
    public class SaveOrderDto
    {
        public Store Store { get; set; }
        public Staff Staff { get; set; }
        public Order Order { get; set; }

    }
}
