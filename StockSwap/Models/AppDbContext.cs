using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
//using System.Data.Entity.Infrastructure;

namespace StockSwap.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<StockTradingEntry> StockTradingLog { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer();
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException(); //Initializes a new instance of the UnintentionalCodeFirstException class.
        //}
    }
}