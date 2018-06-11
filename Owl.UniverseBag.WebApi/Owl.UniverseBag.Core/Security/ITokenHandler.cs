using System;
using System.Collections.Generic;
using System.Text;

namespace Owl.UniverseBag.Core.Security
{
    public interface ITokenHandler
    {
        JWTModel Generate();
    }
}
