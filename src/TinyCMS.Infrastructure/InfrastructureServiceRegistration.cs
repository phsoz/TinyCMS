using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TinyCMS.Infrastructure.Persistence;

namespace TinyCMS.Infrastructure;
public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TinyDatabaseContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("TinyDatabase")));

        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        return services;
    }
}
