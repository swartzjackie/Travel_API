using Travel_API.DataAccess;
using Travel_API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Travel_API.Controllers
{
    public class HomeController : Controller
    {

        public ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public async Task<IActionResult> Travel()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2021-09-01?inboundpartialdate=2021-12-01"),
                Headers =
    {
        { "x-rapidapi-key", "f57bcca65emshe886b913528b726p15120cjsn8125fde6cc43" },
        { "x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(body);
                if (!body.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    TravelInfo r = JsonConvert.DeserializeObject<TravelInfo>(body);
                }
            }
            return View();

        }
    }
}