using API.Data;
using API.Helpers;
using API.Interface;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
     public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
     {
         services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));
         services.AddScoped<ITokenService, TokenService>();
         services.AddScoped<IUserRepository, UserRepository>();
         services.AddScoped<IPhotoService, PhotoService>();
         services.AddScoped<ILikesRepository, LikesRepository>();
         services.AddScoped<LogUserActivity>();
         services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<DataContext>(options =>
            {
                // options.UseSqlite(config.GetConnectionString("DefaultConnection"));
                options.UseSqlite("Data source=datingapp.db");
            }); 

            return services;
     }  
    }
}