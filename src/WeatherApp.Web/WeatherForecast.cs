namespace WeatherApp.Web;

public sealed class WeatherDate
{
    public DateOnly Date { get; set; }
    public string DayOfWeek { get; set; }
}

public sealed class WeatherForecast
{
    public WeatherDate Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}

public sealed class DayByDayWeatherForecast
{
    public IReadOnlyList<WeatherForecast> Forecasts { get; set; }
}