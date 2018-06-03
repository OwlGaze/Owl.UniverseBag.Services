using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Owl.UniverseBag.Domain;

namespace Owl.UniverseBag.WebApi.config
{
    public static class DatabaseConfig
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration Configuration)
        {
            //services.AddDbContext<UBContext>(d => d.UseSqlServer(Configuration["Db:UBConnectionString"]),
            //    ServiceLifetime.Transient);
            return services.AddDbContext<UBContext>(d => d.UseSqlServer(Configuration.GetConnectionString("UB")));
        }
    }
}
