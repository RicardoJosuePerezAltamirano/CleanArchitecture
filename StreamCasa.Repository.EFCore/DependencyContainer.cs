using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StreamCasa.Entities.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Repository.EFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddEFCoreRepositories(this IServiceCollection services,IConfiguration config) {

            services.AddDbContext<StreamDBContext>(options=>
            {
                options.UseSqlServer(config["Connection"], op =>
                {
                    op.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(60), null);
                });
            });
            services.AddScoped<IVideosRepository, VideosRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IUsersVideosRepository, UsersVideosRepository>();
            services.AddScoped<IProfilesRepository, ProfilesRepository>();
            services.AddScoped<IFavoritesRepository, FavoritesRepository>();
            services.AddScoped<ICoursesRepository, CoursesRepository>();
            return services;
        }
    }
}
