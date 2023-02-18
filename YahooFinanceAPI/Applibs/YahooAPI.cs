using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooFinanceAPI.Applibs
{
    internal class YahooAPI
    {
        private readonly HttpClient _httpClient;

        public YahooAPI()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetStockDataAsync(string stockId)
        {
            var url = $"https://query1.finance.yahoo.com/v8/finance/chart/{stockId}?interval=1d";
            var response = await _httpClient.GetAsync(url);
            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent;
        }
    }
}
