using Newtonsoft.Json.Linq;
using YahooFinanceAPI.Models;

namespace YahooFinanceAPI.Applibs
{
    internal class Process
    {
        public static StockInfo FromJson(string json)
        {
            var stockInfo = new StockInfo();

            stockInfo.Symbol = (string)JObject.Parse(json)["chart"]["result"][0]["meta"]["symbol"];

            var data = JObject.Parse(json)["chart"]["result"][0]["indicators"]["quote"][0];
            stockInfo.Open = data["open"][0].Value<decimal>();
            stockInfo.Close = data["close"][0].Value<decimal>();
            stockInfo.High = data["high"][0].Value<decimal>();
            stockInfo.Low = data["low"][0].Value<decimal>();

            return stockInfo;
        }
    }
}
