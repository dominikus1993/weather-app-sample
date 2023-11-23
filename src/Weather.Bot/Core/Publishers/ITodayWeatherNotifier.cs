namespace Weather.Bot.Core.Publishers;

public interface ITodayWeatherNotifier
{
    Task Publish(Types.Weather weather, CancellationToken cancellationToken = default);
}