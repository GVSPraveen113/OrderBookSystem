using Microsoft.EntityFrameworkCore;
using OrderBookSystem.Models;
using System;

namespace OrderBookSystem.Services
{
    public class StockDbContext:DbContext
    {
        public DbSet<Stock> Stocks { get; set; }
        public string DbPath;
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Stocks;Integrated Security=True");

    }
}
