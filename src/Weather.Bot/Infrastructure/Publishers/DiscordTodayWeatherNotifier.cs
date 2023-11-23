using Discord.Webhook;
using Weather.Bot.Core.Publishers;

namespace Weather.Bot.Infrastructure.Publishers;

public sealed class DiscordTodayWeatherNotifier(DiscordWebhookClient discordWebhookClient) : ITodayWeatherNotifier
{

    public Task Publish(Core.Types.Weather weather, CancellationToken cancellationToken = default)
    {
        discordWebhookClient.SendMessageAsync()
    }
}