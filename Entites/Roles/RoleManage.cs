using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.Entites.Roles
{
    public class RoleManage : BaseRole
    {
        [Required]
        public bool PermissionManagement { get; set; }
        [Required]
        public bool PaymentManagement { get; set; }
        [Required]
        public bool OrderProcessManagement { get; set; }
        [Required]
        public bool EditPrintingTemplate { get; set; }
        [Required]
        public bool ViewActiveLog { get; set; }
        [Required]
        public bool EditStoreInformation { get; set; }
        [Required]
        public bool GeneralConfiguration { get; set; } 
    }
}
