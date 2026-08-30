using System.Threading.Tasks;
using System.Threading;
using GoogleApi.Entities.Maps.Geocoding.Common;
using System.Collections.Generic;

namespace Soenneker.Google.Geocode.Abstract;

/// <summary>
/// Provides address lookups through the Google Maps Geocoding API.
/// </summary>
public interface IGoogleGeocodeUtil
{
    /// <summary>
    /// Gets every geocoding candidate returned for an address.
    /// </summary>
    /// <param name="address">The address sent to Google.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>The candidates in Google response order, or <see langword="null"/> when no response is produced.</returns>
    ValueTask<List<Result>?> GetResults(string address, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the first geocoding candidate returned for an address.
    /// </summary>
    /// <param name="address">Address for the get result operation.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>The first candidate, or <see langword="null"/> when none exists.</returns>
    ValueTask<Result?> GetResult(string address, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the place ID from the first geocoding candidate returned for an address.
    /// </summary>
    /// <param name="address">Address for the get place id operation.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>The first candidate's place ID, or <see langword="null"/> when none exists.</returns>
    ValueTask<string?> GetPlaceId(string address, CancellationToken cancellationToken = default);
}
