using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSwap.Models
{
    public interface ITradingService
    {
        bool Buy(BuySellDetails obj);
        bool Sell(BuySellDetails obj);
        List<StockTradingEntry> GetAllTradingLog();
        List<StockTradingEntry> GetTradingLogForUser(string user);
    }
}
