using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.Entites.Roles
{
    public class RoleCustomer : BaseRole
    {

        [Required]
        public bool ViewAssignedCustomers { get; set; }

        [Required]
        public bool ViewAllCustomers { get; set; }

        [Required]
        public bool CreateCustomer { get; set; }

        [Required]
        public bool DeleteCustomer { get; set; }

        [Required]
        public bool EditCustomer { get; set; }
        [Required]
        public bool ExportCustomerFile { get; set; }
        [Required]
        public bool ImportCustomerFile { get; set; }
    }
}
