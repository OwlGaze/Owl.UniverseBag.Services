using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Owl.UniverseBag.WebApi.config
{
    public static class DocumentConfig
    {
        public static void AddSwaggerService(this IServiceCollection services)
        {
            services.AddSwaggerGen(d =>
            {
                d.SwaggerDoc("v1.0", new Info
                {
                    Version = "v1.0",
                    Title = "UniverseBag 接口文档",
                    Description = "RESTful API for UniverseBag",
                    TermsOfService = "None",
                    Contact = new Contact { Name = "Owl", Email = "13170019@qq.com", Url = "https://github.com/OwlGaze/Owl.UniverseBag.Services" }
                });

                //Set the comments path for the swagger json and ui.
                //var basePath = PlatformServices.Default.Application.ApplicationBasePath;//.net core 2.0用法
                var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}App_Data";
                var xmlPath = Path.Combine(basePath, "UniverseBagApi.xml");
                d.IncludeXmlComments(xmlPath);

                //  c.OperationFilter<HttpHeaderOperation>(); // 添加httpHeader参数
            });
        }

        public static void UseSwaggerService(this IApplicationBuilder app)
        {
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "UniverseBag API V1.0");
                //c.ShowRequestHeaders();
            });
        }
    }
}
