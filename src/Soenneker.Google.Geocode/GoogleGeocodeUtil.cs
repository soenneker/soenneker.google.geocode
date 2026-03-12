using System.Collections.Generic;
using System.Linq;
using Soenneker.Google.Geocode.Abstract;
using System.Threading.Tasks;
using System.Threading;
using GoogleApi;
using GoogleApi.Entities.Maps.Geocoding;
using GoogleApi.Entities.Maps.Geocoding.Address.Request;
using Microsoft.Extensions.Configuration;
using Soenneker.Extensions.Configuration;
using GoogleApi.Entities.Maps.Geocoding.Common;
using Soenneker.Extensions.ValueTask;
using Soenneker.Extensions.Task;

namespace Soenneker.Google.Geocode;

/// <inheritdoc cref="IGoogleGeocodeUtil"/>
public class GoogleGeocodeUtil : IGoogleGeocodeUtil
{
    private readonly string _apiKey;

    public GoogleGeocodeUtil(IConfiguration config)
    {
        _apiKey = config.GetValueStrict<string>("Google:Geocode:ApiKey");
    }

    public async ValueTask<List<Result>?> GetResults(string address, CancellationToken cancellationToken = default)
    {
        var geocodeRequest = new AddressGeocodeRequest
        {
            Key = _apiKey,
            Address = address
        };

        GeocodeResponse? geocodeResponse = await GoogleMaps.Geocode.AddressGeocode.QueryAsync(geocodeRequest, cancellationToken).NoSync();

        return geocodeResponse?.Results.ToList();
    }

    public async ValueTask<Result?> GetResult(string address, CancellationToken cancellationToken = default)
    {
        List<Result>? results = await GetResults(address, cancellationToken).NoSync();

        return results?.FirstOrDefault();
    }

    public async ValueTask<string?> GetPlaceId(string address, CancellationToken cancellationToken = default)
    {
        Result? result = await GetResult(address, cancellationToken).NoSync();

        return result?.PlaceId;
    }
}