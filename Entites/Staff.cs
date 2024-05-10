using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomeet_Pos.Entites
{
    public class Staff : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(10, ErrorMessage = "Số điện thoại không hợp lệ")]
        [MaxLength(11, ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Phone { get; set; }

        [MaxLength(200, ErrorMessage ="Mô tả nhân viên tối đa 200 ký tự")]
        public string Description { get; set; }

        public byte[] Photo { get; set; }

        [Index(IsUnique = true)]
        [MinLength(5, ErrorMessage ="Email không hợp lệ")]
        [MaxLength(50, ErrorMessage ="Email không hợp lệ")]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage ="Mật khẩu không hợp lệ")]
        [MaxLength(100, ErrorMessage = "Mật khẩu không hợp lệ")]
        public string Password { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Tên nhân viên phải có ít nhất 5 ký tự")]
        [MaxLength(50, ErrorMessage = "Tên nhân viên không vượt quá 50 ký tự")]
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public StaffGender Gender { get; set; }

        [Required]
        public StaffStatus Status { get; set; }

        [Required]
        public long WorkplaceId { get; set; }


        [Required]
        public Store Workplace { get; set; }


        [Required]
        public Role Role { get; set; }


        public Staff Clone ()
        {
            return (Staff)this.MemberwiseClone();
        }

    }

    public enum StaffStatus
    {
        NOT_STARTED = 1,
        WORKING = 2,
        RESIGNED = 3
    }

    public enum StaffGender
    {
        MALE = 1,
        FEMALE = 2,
        OTHER = 3
    }
}
