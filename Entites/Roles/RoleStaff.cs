using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.Entites.Roles
{
    public class RoleStaff : BaseRole
    {
        [Required]
        public bool ViewAllStaff { get; set; }
        [Required]
        public bool CreateStaff { get; set; }
        [Required]
        public bool EditStaff { get; set; }
        [Required]
        public bool RemoveStaff { get; set; }
        [Required]
        public bool ImportStaffFile { get; set; }
        [Required]
        public bool ExportStaffFile { get; set; }
    }
}
