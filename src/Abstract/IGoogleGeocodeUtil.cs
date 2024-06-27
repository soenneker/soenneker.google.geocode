using System.Threading.Tasks;
using System.Threading;
using GoogleApi.Entities.Maps.Geocoding.Common;

namespace Soenneker.Google.Geocode.Abstract;

/// <summary>
/// A utility library for Google Geocode API operations
/// </summary>
public interface IGoogleGeocodeUtil
{
    ValueTask<Result?> GetResult(string address, CancellationToken cancellationToken = default);

    ValueTask<string?> GetPlaceId(string address, CancellationToken cancellationToken = default);
}