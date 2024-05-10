using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.Entites.Roles
{
    public class RoleOrder : BaseRole
    {
       
        [Required]
        public bool ViewAssignedOrder { get; set; }
        [Required]
        public bool ViewAllOrder { get; set; }
        [Required]
        public bool CreateOrder { get; set; }
        [Required]
        public bool EditOrder { get; set; }
        [Required]
        public bool ApproveOrder { get; set; }
        [Required]
        public bool CancelOrder { get; set; }
        [Required]
        public bool ExportOrderFile { get; set; }
        [Required]
        public bool ImportOrderFile { get; set; }

    }
}
