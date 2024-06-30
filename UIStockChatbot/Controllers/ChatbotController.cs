using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIStockChatbot.Models;

namespace UIStockChatbot.Controllers
{
    public class ChatbotController : Controller
    {
        private readonly List<StockExchange> _stockExchanges;

        public ChatbotController()
        {
            // Load JSON data into _stockExchanges
            //string jsonFilePath = Server.MapPath("~/App_Data/Chatbot - stock data.json");
            string jsonFilePath = Path.Combine(HttpRuntime.AppDomainAppPath, "App_Data/Chatbot-stockdata.json");
            _stockExchanges = LoadStockData(jsonFilePath);
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStockExchanges()
        {
            return Json(_stockExchanges.Select(se => new { se.Code, se.StockExchangeName }), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTopStocks(string exchangeCode)
        {
            var exchange = _stockExchanges.FirstOrDefault(se => se.Code == exchangeCode);
            if (exchange != null)
            {
                return Json(exchange.TopStocks.Select(stock => new { stock.Code, stock.StockName }), JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetStockPrice(string stockCode)
        {
            foreach (var exchange in _stockExchanges)
            {
                var stock = exchange.TopStocks.FirstOrDefault(s => s.Code == stockCode);
                if (stock != null)
                {
                    return Json(stock.Price, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }

        private List<StockExchange> LoadStockData(string filePath)
        {
            try
            {
                string jsonData = System.IO.File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<StockExchange>>(jsonData);
            }
            catch (Exception ex)
            {
                // Handle file read or JSON parse errors
                throw new Exception("Failed to load stock data.", ex);
            }
        }

    }
}