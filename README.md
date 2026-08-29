[![](https://img.shields.io/nuget/v/soenneker.google.geocode.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.google.geocode/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.google.geocode/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.google.geocode/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.google.geocode.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.google.geocode/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.google.geocode/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.google.geocode/actions/workflows/codeql.yml)

# Soenneker.Google.Geocode

A utility library for Google Geocode API operations.

## Install

```bash
dotnet add package Soenneker.Google.Geocode
```

## Quick start

```csharp
using Soenneker.Google.Geocode.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddGoogleGeocodeUtilAsSingleton();
```

Adds `IGoogleGeocodeUtil` as a singleton service.

## What you get

- `IGoogleGeocodeUtil` — A utility library for Google Geocode API operations.
- `GoogleGeocodeUtilRegistrar` — A utility library for Google Geocode API operations.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `GoogleGeocodeUtilRegistrar.AddGoogleGeocodeUtilAsSingleton(services)` | Adds `IGoogleGeocodeUtil` as a singleton service. | The same service collection, so additional registrations can be chained. |
| `GoogleGeocodeUtilRegistrar.AddGoogleGeocodeUtilAsScoped(services)` | Adds `IGoogleGeocodeUtil` as a scoped service. | The same service collection, so additional registrations can be chained. |
