using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TecTradeAPI.Models
{
    public class WatchContext : DbContext
    {
        public WatchContext(DbContextOptions<WatchContext> options) : base(options)
        {
        }
        public DbSet<Watch> Watch { get; set; }
    }
}
