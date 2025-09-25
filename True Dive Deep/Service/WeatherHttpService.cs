using True_Dive_Deep.Service;
using True_Dive_Deep.Models;
namespace True_Dive_Deep.Service
{
    public class WeatherHttpService : IWeatherHttpService
    {
        private readonly HttpClient _httpClient;

        public WeatherHttpService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _httpClient.BaseAddress = new Uri("https://dmigw.govcloud.dk/v1/");
            _httpClient.DefaultRequestHeaders.Add("X-Gravitee-Api-Key", "3b706bf3-3408-4fdd-a6b3-3a332f64135d");
        }
    }
}
