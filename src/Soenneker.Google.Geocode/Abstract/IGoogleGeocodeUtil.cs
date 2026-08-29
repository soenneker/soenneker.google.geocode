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
    /// <param name="address">Address for the get results operation.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the collection returned by get Results.</returns>
    ValueTask<List<Result>?> GetResults(string address, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets result.
    /// </summary>
    /// <param name="address">Address for the get result operation.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested result.</returns>
    ValueTask<Result?> GetResult(string address, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets place id.
    /// </summary>
    /// <param name="address">Address for the get place id operation.</param>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the text returned by get Place ID.</returns>
    ValueTask<string?> GetPlaceId(string address, CancellationToken cancellationToken = default);
}
