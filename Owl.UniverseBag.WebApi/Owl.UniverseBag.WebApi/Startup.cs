﻿using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using Owl.UniverseBag.Domain;
using Owl.UniverseBag.WebApi.config;
using Owl.UniverseBag.WebApi.Config;

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
            services.LayerRegister();
            

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, UBContext db)
        {
            app.UseExceptionScheme(env)
                .UseSwaggerService();
            loggerFactory.AddNLog();
            //AutoMapperHandler.UseAutoMapper();

            app.UseHttpsRedirection();
            app.UseMvc();

            db.InitSeed();
        }
    }
}
