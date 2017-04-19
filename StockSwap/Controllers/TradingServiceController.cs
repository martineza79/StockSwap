﻿using StockSwap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockSwap.Controllers
{
    public class TradingServiceController : Controller, ITradingService
    {
        public bool Buy(BuySellDetails obj)
        {
            TradingRepository repository = new TradingRepository();
            StockTradingEntry entry = new StockTradingEntry();
            entry.UserName = obj.UserName;
            entry.Symbol = obj.Symbol;
            entry.Quantity = obj.Quantity;
            entry.UnitPrice = obj.UnitPrice;
            entry.Operation = "BUY";
            entry.TimeStamp = obj.TimeStamp;
            repository.Insert(entry);
            return true;
        }

        public bool Sell(BuySellDetails obj)
        {
            TradingRepository repository = new TradingRepository();
            StockTradingEntry entry = new StockTradingEntry();
            entry.UserName = obj.UserName;
            entry.Symbol = obj.Symbol;
            entry.Quantity = obj.Quantity;
            entry.UnitPrice = obj.UnitPrice;
            entry.Operation = "SELL";
            entry.TimeStamp = obj.TimeStamp;
            repository.Insert(entry);
            return true;

        }

        public List<StockTradingEntry> GetAllTradingLog()
        {
            TradingRepository repository = new TradingRepository();
            return repository.SelectAll();
        }

        public List<StockTradingEntry> GetTradingLogForUser(string user)
        {
            TradingRepository repository = new TradingRepository();
            return repository.SelectForUser(user);
        }
    }
}