using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites;

namespace Toomeet_Pos.DTOs
{
    public class InviteStaffMailDto
    {

        public string StaffEmail { get; set; }
        public string StaffPhone { get; set; }
        public string StaffName { get; set; }
        public string StaffPassword { get; set; }
        public string StoreName { get; set; }
        public string StoreEmail { get; set; }
        public string StorePhone { get; set; }
        public string StoreOwnerName { get; set; }

    }
}
