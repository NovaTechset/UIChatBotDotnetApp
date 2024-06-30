using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UIStockChatbot.Models
{
    public class StockExchange
    {
        public string Code { get; set; }
        public string StockExchangeName { get; set; }
        public List<Stock> TopStocks { get; set; }

    }
}