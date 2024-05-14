using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.Entites.Products
{
    public class Category : BaseEntity
    {
        
        [Key]
        public long Id { get; set; }

        [Required]
        public string Code { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public long StoreId { get; set; }

        [ForeignKey("StoreId")]
        public Store Store { get; set; }

        public List<Product> Products { get; set; }

    }
}
