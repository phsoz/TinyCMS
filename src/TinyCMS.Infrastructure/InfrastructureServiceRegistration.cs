using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TinyCMS.Application.Contracts.Persistence;
using TinyCMS.Infrastructure.Persistence;
using TinyCMS.Infrastructure.Repositories;

namespace TinyCMS.Infrastructure;
public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TinyDatabaseContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("TinyDatabase")));

        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IPostCategoryRepository, PostCategoryRepository>();
        services.AddScoped<IPostCommentRepository, PostCommentRepository>();
        services.AddScoped<IPostMetaRepository, PostMetaRepository>();
        services.AddScoped<IPostRepository, PostRepository>();
        services.AddScoped<IPostTagRepository, PostTagRepository>();
        services.AddScoped<ITagRepository, TagRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
