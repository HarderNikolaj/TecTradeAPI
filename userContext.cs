using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TecTradeAPI.Models
{
    public class userContext : DbContext
    {
        public userContext(DbContextOptions<userContext> options) : base(options)
        {
        }
        public DbSet<user> Users { get; set; }
    }
}