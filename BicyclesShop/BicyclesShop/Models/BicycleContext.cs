using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicyclesShop.Models
{
    public class BicycleContext : DbContext
    {
        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public BicycleContext(DbContextOptions<BicycleContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
