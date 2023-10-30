namespace WeatherApp.Web.Core.Services;

public readonly record struct Coordinates(double Latitude, double Longitude);
public sealed record GetWeatherForecastQuery(Coordinates Coordinates, DateOnly Date);

public interface IWeatherForecastProvider
{
    Task<DayByDayWeatherForecast> GetWeatherForecastAsync(GetWeatherForecastQuery query, CancellationToken cancellationToken = default);
}