using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TecTradeAPI.Models
{
    public class AssetTypeContext : DbContext
    {
        public AssetTypeContext(DbContextOptions<AssetTypeContext> options) : base(options)
        {
        }
        public DbSet<AssetType> AssetType { get; set; }
    }
}
