using Cocona;
using Cocona.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Weather.Bot.Core.UseCase;

var builder = CoconaApp.CreateBuilder();
builder.Services.AddScoped<CheckTodayWeather>();
builder.Configuration.AddJsonFile("appsettings.custom.json", optional: true);

var app = builder.Build();

app.UseFilter(new LoggingFilter(app.Services.GetRequiredService<ILogger<LoggingFilter>>()));

app.AddCommand(async ([FromService] CheckTodayWeather weather, CoconaAppContext ctx) =>
{
    await weather.Execute(ctx.CancellationToken);
});

app.Run();

class LoggingFilter : CommandFilterAttribute
{
    private readonly ILogger _logger;

    public LoggingFilter(ILogger<LoggingFilter> logger)
    {
        _logger = logger;
    }
    public override async ValueTask<int> OnCommandExecutionAsync(CoconaCommandExecutingContext ctx, CommandExecutionDelegate next)
    {
        _logger.LogInformation($"Before {ctx.Command.Name}");
        try
        {
            return await next(ctx);
        }
        finally
        {
            _logger.LogInformation($"End {ctx.Command.Name}");
        }
    }
}