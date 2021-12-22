using System;
using OrderBookSystem.Models.Enums;

namespace OrderBookSystem.Models
{
    public class Stock
    {
        public string StockId { get; set; }
        public string StockName { get; set; }
        public OrderType OrderType { get; set; }
        public int OrderQty { get; set; }
        public int ExecutedQty { get; set; }
        public int OrderPrice { get; set; }
        public int ExecutionPrice { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
