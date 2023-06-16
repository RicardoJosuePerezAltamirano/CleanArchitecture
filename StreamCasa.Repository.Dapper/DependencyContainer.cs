using Microsoft.Extensions.DependencyInjection;
using StreamCasa.Entities.Abstractions.Repositories.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Repository.Dapper
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDapperRepository(this IServiceCollection services)
        {
            services.AddScoped<Connection>();
            services.AddScoped<IQueryVideosRepository, QueryVideosRepository>();
            return services;
        }
    }
}
