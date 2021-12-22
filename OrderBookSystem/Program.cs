using OrderBookSystem.Services;
using System;

namespace OrderBookSystem.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerServices customerServices = new CustomerServices();
            customerServices.CreateOrder();
            AdminServices adminServices = new AdminServices();
            adminServices.ExecuteOrder();
        }
    }
}
