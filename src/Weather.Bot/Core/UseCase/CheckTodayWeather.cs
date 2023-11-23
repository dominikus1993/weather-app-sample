using Microsoft.Extensions.Logging;
using Weather.Bot.Core.Providers;
using Weather.Bot.Core.Publishers;

namespace Weather.Bot.Core.UseCase;

public sealed class CheckTodayWeather(ILogger<CheckTodayWeather> logger, IWeatherDataProvider weatherDataProvider, IEnumerable<ITodayWeatherNotifier> notifiers)
{
    public async Task Execute(CancellationToken cancellationToken)
    {
        logger.LogInformation("Start");
        var data = await weatherDataProvider.Provide(new GetWeatherDataQuery(), cancellationToken);

        var weather = new Types.Weather(data);
        await Publish(weather, cancellationToken);
    }

    private async Task Publish(Types.Weather weather, CancellationToken cancellationToken)
    {
        var tasks = new List<Task>();

        foreach (var notifier in notifiers)
        {
            tasks.Add(notifier.Publish(weather, cancellationToken));
        }

        await Task.WhenAll(tasks);
    }
}