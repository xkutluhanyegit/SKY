using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\SKY\Desktop\SKY\DataAccess/SQLite/SkyApp.db");
        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Order> orders { get; set; }
    }
}