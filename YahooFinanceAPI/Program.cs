using System;
using System.Threading.Tasks;
using YahooFinanceAPI.Applibs;
using YahooFinanceAPI.Models;


namespace YahooFinanceAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // 股票代號
            string symbol = "2330.TW";
            YahooAPI api = new YahooAPI();
            string responseContent = await api.GetStockDataAsync(symbol);
            StockInfo stockPrice = Process.FromJson(responseContent);
            Console.WriteLine($"Symbol: {stockPrice.Symbol}, Open: {stockPrice.Open}, Close: {stockPrice.Close}, High: {stockPrice.High}, Low: {stockPrice.Low}");
            Console.ReadLine();
        }
    }
}
