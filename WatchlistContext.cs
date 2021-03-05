using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TecTradeAPI.Models
{
    public class WatchlistContext : DbContext
    {
        public WatchlistContext(DbContextOptions<WatchlistContext> options) : base(options)
        {
        }
        public DbSet<Watchlist> Watchlist { get; set; }
    }
}
