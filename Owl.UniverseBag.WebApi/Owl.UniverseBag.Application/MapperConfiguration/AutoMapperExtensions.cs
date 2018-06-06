using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Owl.UniverseBag.Application.MapperConfiguration
{
    public static class AutoMapperExtensions
    {
        public static TTarget Map<TTarget,TSource>(this TSource source, IMapper mapper)
        {
           return mapper.Map<TTarget>(source);
        }
    }
}
