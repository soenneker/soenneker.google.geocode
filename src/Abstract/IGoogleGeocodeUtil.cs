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
    ValueTask<List<Result>?> GetResults(string address, CancellationToken cancellationToken = default);

    ValueTask<Result?> GetResult(string address, CancellationToken cancellationToken = default);

    ValueTask<string?> GetPlaceId(string address, CancellationToken cancellationToken = default);
}