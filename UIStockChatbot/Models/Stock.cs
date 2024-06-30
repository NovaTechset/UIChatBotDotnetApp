using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UIStockChatbot.Models
{
    public class Stock
    {
        public string Code { get; set; }
        public string StockName { get; set; }
        public double Price { get; set; }
    }
}