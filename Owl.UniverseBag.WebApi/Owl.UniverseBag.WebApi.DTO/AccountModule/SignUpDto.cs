using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace Owl.UniverseBag.Application.DTO.AccountModule
{
    public class SignUpDto
    {
        public string PhoneNumber { get; set; }

        public string Password { get; set; }
    }

    public class SignUpDtoValidate : AbstractValidator<SignUpDto>
    {
        public SignUpDtoValidate()
        {
            RuleFor(d => d.PhoneNumber).NotNull().WithMessage("手机号码不能为空")
                .Length(11).WithMessage("手机号码异常");
            RuleFor(d => d.Password).NotEmpty().WithMessage("密码不能为空");
        }
    }
}
