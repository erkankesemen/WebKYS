using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KYS.Entity;
using Microsoft.EntityFrameworkCore;

namespace KYS.Data.Concrete
{
    public class NetContext : DbContext
    {
        public NetContext(DbContextOptions<NetContext> options) : base(options)
        {
        }

        public DbSet<AracBilgi> AracBilgileri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
