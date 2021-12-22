using OrderBookSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBookSystem.Services
{
    public class AdminServices
    {
        StockDbContext stockDb = new StockDbContext();
        public int executionPrice = 1000;
        public int executionQty = 1000;
        public bool ExecuteOrder()
        {
            List<Stock> stocks = stockDb.Stocks.ToList();
            foreach (Stock stock in stocks){
                if (stock.OrderType == Models.Enums.OrderType.Market)
                {
                    stock.Status = Models.Enums.OrderStatus.Accepted;
                    stock.ExecutionPrice = executionPrice;
                    stock.ExecutedQty = executionQty;
                }
                else if (stock.OrderPrice > executionPrice)
                {
                    stock.Status = Models.Enums.OrderStatus.Rejected;
                }
                stockDb.Update(stock);
            }
            stockDb.SaveChanges();
            return true;
        }
    }
}
