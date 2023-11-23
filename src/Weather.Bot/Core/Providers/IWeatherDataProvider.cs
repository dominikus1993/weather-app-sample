using Weather.Bot.Core.Types;

namespace Weather.Bot.Core.Providers;

public sealed record GetWeatherDataQuery();

public interface IWeatherDataProvider
{
    Task<WeatherData> Provide(GetWeatherDataQuery query, CancellationToken cancellationToken = default);
}