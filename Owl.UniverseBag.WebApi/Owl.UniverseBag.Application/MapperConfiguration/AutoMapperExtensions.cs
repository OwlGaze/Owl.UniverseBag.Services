using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Owl.UniverseBag.Application.MapperConfiguration
{
    public static class AutoMapperExtensions
    {
        public static TTarget Map<TTarget>(this object source, IMapper mapper)
        {
           return mapper.Map<TTarget>(source);
        }
    }
}
