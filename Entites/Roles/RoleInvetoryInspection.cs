using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.Roles;

namespace Toomeet_Pos.Entites
{
    public class RoleInvetoryInspection: BaseRole
    {
    
        [Required]
        public bool ViewInVentoryCount { get; set; }
        [Required]
        public bool CreateInventoryCount { get; set; }
        [Required]
        public bool EditInventoryCount { get; set; }
        [Required]
        public bool BalanceInventory { get; set; }
        [Required]
        public bool DeleteInventoryCount { get; set; }
        [Required]
        public bool ExportInventoryCountFile { get; set; }
        [Required]
        public bool ImportInventoryCountFile { get; set; }

    }
}
