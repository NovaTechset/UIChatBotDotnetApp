using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using UIStockChatbot.Models;

namespace UIStockChatbot.Services
{
    public class StockService
    {
        private readonly List<StockExchange> _stockExchanges;

        public StockService()
        {
            var jsonFile = Path.Combine(HttpRuntime.AppDomainAppPath, "App_Data/Chatbot-stockdata.json");
            var json = File.ReadAllText(jsonFile);
            _stockExchanges = JsonConvert.DeserializeObject<List<StockExchange>>(json);
        }

        public List<StockExchange> GetStockExchanges() => _stockExchanges;

        public StockExchange GetStockExchangeByCode(string code) =>
            _stockExchanges.FirstOrDefault(se => se.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
    }
}