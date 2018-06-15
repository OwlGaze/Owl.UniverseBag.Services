using System;
using System.Collections.Generic;
using System.Text;

namespace Owl.UniverseBag.Repository.Repositories
{
    public interface IBaseRepository<out T>
    {
        T Find(Guid id);
    }
}
