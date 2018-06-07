using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Owl.UniverseBag.Application.Services.AccountModule;
using Owl.UniverseBag.Repository.Repositories.AccountModule;

namespace Owl.UniverseBag.WebApi.Config
{
    public static class LayerRegisterHandler
    {
        public static void LayerRegister(this IServiceCollection services)
        {
            //repository
            services.AddScoped<IUserRepository, UserRepository>();
            //application
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}
