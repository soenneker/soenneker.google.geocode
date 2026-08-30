using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Google.Geocode.Abstract;

namespace Soenneker.Google.Geocode.Registrars;

/// <summary>
/// Registers the Google Maps geocoding utility.
/// </summary>
public static class GoogleGeocodeUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IGoogleGeocodeUtil"/> as a singleton service. <para/>
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddGoogleGeocodeUtilAsSingleton(this IServiceCollection services)
    {
        services.TryAddSingleton<IGoogleGeocodeUtil, GoogleGeocodeUtil>();
        return services;
    }

    /// <summary>
    /// Adds <see cref="IGoogleGeocodeUtil"/> as a scoped service. <para/>
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddGoogleGeocodeUtilAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<IGoogleGeocodeUtil, GoogleGeocodeUtil>();
        return services;
    }
}
