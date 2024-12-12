using Microsoft.AspNetCore.Mvc;
using MyRapidApiProject.Models;
using Newtonsoft.Json;

namespace MyRapidApiProject.Controllers
{
    public class CurrencyController : Controller
    {
        public async Task<IActionResult> CurrencyList()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=100"),
                Headers =
    {
        { "x-rapidapi-key", "d4a58d4634mshef481a542f465a0p11b614jsn299da005958a" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ApiExchangeViewModel>(body);
                ViewBag.v=values.result;
                return View();
            }
        }
    }
}
