using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.DTOs
{
    public class NewStaffDto
    {
        public Staff Staff { get; set; }
        public Store Store { get; set; }
        public Role Role { get; set; }
    }
}
