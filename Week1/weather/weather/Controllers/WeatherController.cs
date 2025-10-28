using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq; // install this package (next step)

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "c29efe6c928a10653a12d2f38cceb776"; // 🔑 Replace this with your OpenWeatherMap key

        public WeatherController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet("city")]
        public async Task<IActionResult> GetWeather(string city)
        {
            if (string.IsNullOrEmpty(city))
                return BadRequest("City name is required!");

            // API call to OpenWeatherMap
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return NotFound("City not found or invalid API key!");

            var data = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(data);

            // extract details from JSON
            var weatherData = new
            {
                City = json["name"]?.ToString(),
                Temperature = json["main"]?["temp"] + " °C",
                Condition = json["weather"]?[0]?["description"]?.ToString(),
                Humidity = json["main"]?["humidity"] + " %",
                WindSpeed = json["wind"]?["speed"] + " m/s"
            };

            return Ok(weatherData);
        }
    }
}

