﻿using System;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace Owl.UniverseBag.Application.MapperConfiguration
{
    public static class AutoMapperHandler
    {
        public static void UseAutoMapper()
        {
            //AutoMapper.Mapper.Initialize(config => config.AddProfile(new AccountProfile()));


            //获取所有IProfile实现类
            var allType = Assembly
                    .GetEntryAssembly()//获取默认程序集
                    .GetReferencedAssemblies()//获取所有引用程序集
                    .Select(Assembly.Load)
                    .SelectMany(y => y.DefinedTypes)
                    .Where(type => typeof(IProfile).GetTypeInfo().IsAssignableFrom(type.AsType()));

            foreach (var typeInfo in allType)
            {
                var type = typeInfo.AsType();
                if (type.Equals(typeof(IProfile)))
                {
                    //注册映射
                    Mapper.Initialize(y =>
                    {
                        y.AddProfiles(type); // Initialise each Profile classe
                        });
                }
            }
        }


    }
}
