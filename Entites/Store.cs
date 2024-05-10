using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.Products;

namespace Toomeet_Pos.Entites
{
    public class Store : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(5, ErrorMessage = "Tên cửa hàng không hợp lệ")]
        [MaxLength(50, ErrorMessage ="Tên cửa hàng không hợp lệ")]
        public string Name { get; set; }


        public byte[] Photo { get; set; }

        [MinLength(5, ErrorMessage = "Mô tả cửa hàng không hợp lệ")]
        [MaxLength(1000, ErrorMessage = "Mô tả cửa hàng không hợp lệ")]
        public string Description { get; set; }

        public string Address { get; set; }

        public Staff Owner { get; set; }

        public List<Staff> Staffs { get; set; }

        public List<Role> Roles { get; set; }

        public List<Product> Products { get; set; }
    }
}
