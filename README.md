[![](https://img.shields.io/nuget/v/soenneker.google.geocode.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.google.geocode/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.google.geocode/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.google.geocode/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.google.geocode.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.google.geocode/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.google.geocode/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.google.geocode/actions/workflows/codeql.yml)

# Soenneker.Google.Geocode

A small DI-ready wrapper around Google Maps address geocoding for retrieving all matches, the first match, or its place ID.

## Install

```bash
dotnet add package Soenneker.Google.Geocode
```

## Configuration

```json
{
  "Google": {
    "Geocode": {
      "ApiKey": "<Google Maps API key>"
    }
  }
}
```

Enable the Geocoding API for the key and restrict the key appropriately for the application that uses it.

## Register

```csharp
using Soenneker.Google.Geocode.Registrars;
using Microsoft.Extensions.DependencyInjection;

services.AddGoogleGeocodeUtilAsScoped();
```

Singleton registration is also available through `AddGoogleGeocodeUtilAsSingleton()`; the implementation is stateless after reading its API key.

## Usage

```csharp
Result? result = await geocode.GetResult(
    "1600 Amphitheatre Parkway, Mountain View, CA",
    cancellationToken);

if (result is not null)
    Console.WriteLine($"{result.FormattedAddress} ({result.PlaceId})");
```

Use `GetResults()` when every Google candidate matters. `GetResult()` returns Google's first candidate, and `GetPlaceId()` returns that candidate's place ID directly.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `GetResults(address)` | Sends an address-geocoding request. | Returns Google's candidates in response order, or `null` if no response is produced. |
| `GetResult(address)` | Gets the first candidate. | Returns `null` when no candidate exists. |
| `GetPlaceId(address)` | Gets the first candidate's place ID. | Returns `null` when no candidate exists. |

## Behavior

- The address is sent to Google as provided; this package does not normalize or validate it locally.
- A first result is not a guarantee of an exact match. Inspect the full `Result` when match quality matters.
- Google API and transport failures propagate to the caller. Cancellation is forwarded to the request.
