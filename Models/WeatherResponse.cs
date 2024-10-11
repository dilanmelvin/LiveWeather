namespace LiveWeather.Models;
public class WeatherResponse
{
    public required Location Location { get; set; }
    public required Current Current { get; set; }
    public Forecast Forecast { get; set; } // Add forecast property
}

public class Forecast
{
    public List<ForecastDay> Forecastday { get; set; } = new();
}

public class ForecastDay
{
    public string Date { get; set; } = default!;
    public Day Day { get; set; } = default!;
}

public class Day
{
    public float Maxtemp_C { get; set; }
    public float Mintemp_C { get; set; }
    public Condition Condition { get; set; } = default!;
}
