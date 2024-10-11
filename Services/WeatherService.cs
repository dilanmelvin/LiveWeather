namespace LiveWeather.Services
{
    using Microsoft.Extensions.Options;
    using LiveWeather.Models;
    using System.Net.Http.Json; // Make sure you have this using directive

    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly WeatherApiOptions _options;

        public WeatherService(HttpClient httpClient, IOptions<WeatherApiOptions> options)
        {
            _httpClient = httpClient;
            _options = options.Value;
        }

        public async Task<WeatherResponse?> GetWeatherAsync(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                return null; // Handle empty city input
            }

            // Fetch the weather data
            var weather = await _httpClient.GetFromJsonAsync<WeatherResponse>($"?key={_options.ApiKey}&q={city}");
            return weather; // Return the weather response or null
        }
    }
}
