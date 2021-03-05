using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TecTradeAPI.Models
{
    public class Watch
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public int AssetTypeId { get; set; }
        public int WatchlistId { get; set; }
    }
}
