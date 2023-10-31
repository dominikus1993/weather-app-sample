namespace WeatherApp.Web.Infrastructure.Types;

public sealed class OpenWeatherData
{
    public double Temp { get; set; }
    public double FeelsLike { get; set; }
}

public sealed class OpenWeatherResponse
{
    public decimal Lat { get; set; }
    public decimal Lon { get; set; }
    public string Timezone { get; set; }
    public int TimezoneOffset { get; set; }
    public IReadOnlyCollection<OpenWeatherData> Data { get; set; }
    
}