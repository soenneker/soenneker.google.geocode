using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Soenneker.Google.Geocode.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;


namespace Soenneker.Google.Geocode.Tests;

[Collection("Collection")]
public class GoogleGeocodeUtilTests : FixturedUnitTest
{
    private readonly IGoogleGeocodeUtil _util;

    public GoogleGeocodeUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IGoogleGeocodeUtil>(true);
    }
}
