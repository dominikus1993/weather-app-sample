using Microsoft.Extensions.Logging;

namespace Weather.Bot.Core.UseCase;

public sealed class CheckTodayWeather
{
    private readonly ILogger<CheckTodayWeather> _logger;

    public CheckTodayWeather(ILogger<CheckTodayWeather> logger)
    {
        _logger = logger;
    }

    public async Task Execute(CancellationToken cancellationToken)
    {
        _logger.LogInformation("XDDD");
    }
}