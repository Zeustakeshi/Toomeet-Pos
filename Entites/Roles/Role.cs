using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites.Roles;

namespace Toomeet_Pos.Entites
{
    public class Role : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Tên quyền có ít nhất 5 ký tự")]
        [MaxLength(50, ErrorMessage = "Tên quyền không vượt quá 50 ký tự")]
        public string Name { get; set; }

        [MinLength(5, ErrorMessage = "Mô tả quyền có ít nhất 5 ký tự")]
        [MaxLength(200, ErrorMessage = "Mô tả quyền không vượt quá 200 ký tự")]
        public string Description { get; set; }

        [Required]
        public long StoreId { get; set; }

        [Required]
        [ForeignKey("StoreId")]
        public  Store Store { get; set; }

        [Required]
        public  RoleCustomer Customer { get; set; }


        [Required]
        public  RoleInvetoryInspection InvetoryInspection { get; set; }


        [Required]
        public  RoleManage Manage { get; set; }


        [Required]
        public RoleOrder Order { get; set; }


        [Required]
        public  RoleProduct Product { get; set; }


        [Required]
        public RoleStaff Staff { get; set; }

        public List<Staff> Staffs { get; set; }
    }   
}
