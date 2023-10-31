using WeatherApp.Web.Core.Services;

namespace WeatherApp.Web.Infrastructure.Services;

public sealed class HttpWeatherForecastProvider : IWeatherForecastProvider
{
    public async Task<DayByDayWeatherForecast> GetWeatherForecastAsync(GetWeatherForecastQuery query, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}