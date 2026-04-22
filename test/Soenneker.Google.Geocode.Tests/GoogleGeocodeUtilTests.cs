using Soenneker.Google.Geocode.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Google.Geocode.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class GoogleGeocodeUtilTests : HostedUnitTest
{
    private readonly IGoogleGeocodeUtil _util;

    public GoogleGeocodeUtilTests(Host host) : base(host)
    {
        _util = Resolve<IGoogleGeocodeUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
