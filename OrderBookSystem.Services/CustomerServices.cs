using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBookSystem.Models;

namespace OrderBookSystem.Services
{
    public class CustomerServices
    {
        public bool CreateOrder()
        {
            StockDbContext stockDb = new StockDbContext();
            Stock stockT = new Stock
            {
                StockId = "Keka",
                StockName = "Technovert",
                OrderType = Models.Enums.OrderType.Limit,
                OrderQty = 100,
                OrderPrice = 1000
            };
            stockDb.Stocks.Add(stockT);
            stockDb.SaveChanges();
            return true;
        }
    }
}
