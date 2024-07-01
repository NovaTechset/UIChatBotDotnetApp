using System;
using System.Linq;
using System.Web.Mvc;
using UIStockChatbot.Services;

namespace UIStockChatbot.Controllers
{
    public class HomeController : Controller
    {
        private readonly StockService _stockService;

        public HomeController()
        {
            _stockService = new StockService();
        }

        public ActionResult Index()
        {
            var stockExchanges = _stockService.GetStockExchanges();
            if (stockExchanges == null || !stockExchanges.Any())
            {
                ViewBag.ErrorMessage = "No stock exchanges found.";
            }
            return View(stockExchanges);
        }

        public ActionResult StockMenu(string code)
        {
            var stockExchange = _stockService.GetStockExchangeByCode(code);
            if (stockExchange == null)
            {
                return HttpNotFound();
            }
            return View(stockExchange);
        }

        public ActionResult StockDetails(string exchangeCode, string stockCode)
        {
            var stockExchange = _stockService.GetStockExchangeByCode(exchangeCode);
            if (stockExchange == null)
            {
                return HttpNotFound();
            }
            var stock = stockExchange.TopStocks.FirstOrDefault(s => s.Code.Equals(stockCode, StringComparison.OrdinalIgnoreCase));
            if (stock == null)
            {
                return HttpNotFound();
            }
            return View(stock);
        }
    }
}