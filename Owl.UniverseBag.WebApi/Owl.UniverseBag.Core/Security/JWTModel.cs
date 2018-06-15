using System;

namespace Owl.UniverseBag.Core.Security
{
    public class JWTModel
    {
        public string Access_Token { get; set; }
        public string Token_Type { get; set; } = "Bearer";
        public Profile Profile { get; set; }
    }


    public class Profile
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public long Auth_Time { get; set; }
        public long Exprires_At { get; set; }
    }
}
