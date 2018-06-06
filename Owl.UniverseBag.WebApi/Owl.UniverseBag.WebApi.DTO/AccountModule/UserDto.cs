using System;

namespace Owl.UniverseBag.Application.DTO.AccountModule
{
    public class UserDto
    {
        public string Salt { get; set; }

        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
