using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owl.UniverseBag.Domain
{
    [Table("User")]
    public class User
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// 电话号码(登录账号)
        /// </summary>
        [Required]
        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Salt { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        [Required]
        public DateTime RegisterTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
