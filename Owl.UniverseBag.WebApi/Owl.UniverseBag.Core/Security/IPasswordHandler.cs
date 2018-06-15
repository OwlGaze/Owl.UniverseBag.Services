using System;
using System.Collections.Generic;
using System.Text;

namespace Owl.UniverseBag.Core.Security
{
    public interface IPasswordHandler
    {
        string GenerateSalt();
        string Encryption(string password, string salt);
    }
}
