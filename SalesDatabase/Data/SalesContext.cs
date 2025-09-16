using Microsoft.EntityFrameworkCore;
using SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SalesDatabase.Data
{
    internal class SalesContext:DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Sale> sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
       optionsBuilder.UseSqlServer("Data Source =.;Initial Catalog=SalesDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt=True;Trust Server Certificate=True;Application Intent = ReadWrite; Multi Subnet Failover=False");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
             .Property(b => b.Description)
             .HasDefaultValueSql("No description");


            modelBuilder.Entity<Sale>()
            .Property(b => b.Date)
            .HasDefaultValueSql("getdate()");





           






        }
    }
}
