using System;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using Owl.UniverseBag.Application.MapperConfiguration;
using Owl.UniverseBag.Application.Services.AccountModule;
using Owl.UniverseBag.Domain;
using Owl.UniverseBag.WebApi.config;

namespace Owl.UniverseBag.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext(Configuration)
                .AddSwaggerService();
            services.AddAutoMapper();

            services.AddScoped<IAccountService, AccountService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, UBContext ubContext)
        {
            app.UseExceptionScheme(env)
                .UseSwaggerService();
            loggerFactory.AddNLog();
            //AutoMapperHandler.UseAutoMapper();

            app.UseHttpsRedirection();
            app.UseMvc();

            DbSeed.Init(ubContext);
        }
    }
}
