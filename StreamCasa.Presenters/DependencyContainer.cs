using Microsoft.Extensions.DependencyInjection;
using StreamCasa.Interactors.Abstractions.Videos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamCasa.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<IAddVideosOutputPort, VideosPresenter>();
            return services;
        }
    }
}
