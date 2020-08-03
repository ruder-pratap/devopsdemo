using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
using ProductPortal.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductPortal.Repository.MyDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        // optionsBuilder.UseMySql("Server=127.0.0.1; Port=3306; Database=portalDb; Uid=root; Pwd=database;", options => options.EnableRetryOnFailure());

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
