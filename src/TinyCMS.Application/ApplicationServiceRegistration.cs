using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TinyCMS.Application.Interfaces;
using TinyCMS.Application.Services;

namespace TinyCMS.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
