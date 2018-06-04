using System.ComponentModel.DataAnnotations;

namespace Owl.UniverseBag.Application.DTO.AccountModule
{
    public class SignUpDto
    {
        [Display(Name = "手机号码")]
        [Required(ErrorMessage = "{0}是必填项")]
        //[MinLength(2, ErrorMessage = "{0}的最小长度是{1}")]
        //[MaxLength(10, ErrorMessage = "{0}的长度不可以超过{1}")]
        //[StringLength(10, MinimumLength = 2, ErrorMessage = "{0}的长度应该不小于{2}, 不大于{1}")]
        [MinLength(11, ErrorMessage = "{0}最少{1}位")]
        [MaxLength(11, ErrorMessage = "{0}的长度不可以超过{1}位")]
        public string PhoneNumber { get; set; }

        [Display(Name = "登录密码")]
        [Required(ErrorMessage = "{0}是必填项")]

        public string Password { get; set; }
    }
}
