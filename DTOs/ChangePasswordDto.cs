using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.DTOs
{
    public class ChangePasswordDto
    {
        public long StaffId { get; set; }
        public string CurrentPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
