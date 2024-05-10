using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.Roles;

namespace Toomeet_Pos.Entites
{
    public class RoleProduct : BaseRole
    {

        [Required]
        public bool CreateProduct { get; set; }
        [Required]
        public bool ViewProduct { get; set; }
        [Required]
        public bool EditProduct { get; set; }
        [Required]
        public bool DeleteProduct { get; set; }
        [Required]
        public bool ExportProductFile { get; set; }
        [Required]
        public bool ImportProductFile { get; set; }
    }
}
