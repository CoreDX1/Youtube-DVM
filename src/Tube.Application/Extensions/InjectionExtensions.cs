using Microsoft.Extensions.DependencyInjection;
using Tube.Application.Interfaces;
using Tube.Application.Services;

namespace Tube.Application.Extensions;

public static class InjectionExtensions
{
    public static IServiceCollection AddInjectionApplication(this IServiceCollection services)
    {
        services.AddScoped<IVideoApplication, VideoApplication>();
        return services;
    }
}
