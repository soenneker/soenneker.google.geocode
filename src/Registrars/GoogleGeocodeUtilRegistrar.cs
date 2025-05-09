﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Google.Geocode.Abstract;

namespace Soenneker.Google.Geocode.Registrars;

/// <summary>
/// A utility library for Google Geocode API operations
/// </summary>
public static class GoogleGeocodeUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IGoogleGeocodeUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddGoogleGeocodeUtilAsSingleton(this IServiceCollection services)
    {
        services.TryAddSingleton<IGoogleGeocodeUtil, GoogleGeocodeUtil>();
        return services;
    }

    /// <summary>
    /// Adds <see cref="IGoogleGeocodeUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddGoogleGeocodeUtilAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<IGoogleGeocodeUtil, GoogleGeocodeUtil>();
        return services;
    }
}
