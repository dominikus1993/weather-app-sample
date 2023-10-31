using WeatherApp.Web.Core.Services;

namespace WeatherApp.Web.Infrastructure.Services;

.public sealed class HttpWeatherForecastProvider(HttpClient client) : IWeatherForecastProvider
{
    public async Task<DayByDayWeatherForecast> GetWeatherForecastAsync(GetWeatherForecastQuery query, CancellationToken cancellationToken = default)
    {
        var uri = new Uri(
            $"https://api.openweathermap.org/data/3.0/onecall?lat={query.Coordinates.Latitude}&lon={query.Coordinates.Longitude}&appid={{API key}}");
        using var request = new HttpRequestMessage(HttpMethod.Get, uri);
        var response = await client.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadFromJsonAsync<dynamic>(cancellationToken: cancellationToken);
    }
}