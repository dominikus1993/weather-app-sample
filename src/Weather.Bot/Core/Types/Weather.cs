namespace Weather.Bot.Core.Types;

public sealed class Feel
{
    public string Name { get; }
    public string Text { get; }

    private Feel(string name, string text)
    {
        
    }

    public static readonly Feel Fine = new Feel("Fine", "Jest git");
}

public sealed record WeatherData(decimal CelsiusDegree, Feel Feel)
{
}

public sealed record Weather(WeatherData Data)
{
    
}