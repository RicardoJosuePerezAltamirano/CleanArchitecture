using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Builders
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBuilders(this IServiceCollection services )
        {
            services.AddScoped<VideosBuilder>();
            return services;
        }
    }
}
