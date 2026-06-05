using System.Threading.Tasks;
using System.Threading;
using GoogleApi.Entities.Maps.Geocoding.Common;
using System.Collections.Generic;

namespace Soenneker.Google.Geocode.Abstract;

/// <summary>
/// A utility library for Google Geocode API operations
/// </summary>
public interface IGoogleGeocodeUtil
{
    /// <summary>
    /// Gets results.
    /// </summary>
    /// <param name="address">The address.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<List<Result>?> GetResults(string address, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets result.
    /// </summary>
    /// <param name="address">The address.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<Result?> GetResult(string address, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets place id.
    /// </summary>
    /// <param name="address">The address.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<string?> GetPlaceId(string address, CancellationToken cancellationToken = default);
}