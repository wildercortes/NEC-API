using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NEC.Core.DTOs;
using NEC.Core.Models;
using NEC.Core.Static;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NEC.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinMarketCapController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public CoinMarketCapController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        public async Task<IEnumerable<DataDTO>> GetDataFromCoinMarketCapApi()
        {
            var url = configuration["CoinMarketCap:Url"];

            var key = configuration["CoinMarketCap:Key"];

            using var http = new HttpClient();
            http.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", key);

            var response = await http.GetStringAsync(url);

            var coins = JsonConvert.DeserializeObject<Coin>(response);

            return coins.Data.Where(x => RequestedCoins.CoinList.Contains(x.Name)).Select(x => new DataDTO(x)).ToList();
        }

    }
}
