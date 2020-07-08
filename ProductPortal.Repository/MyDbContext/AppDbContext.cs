using Microsoft.EntityFrameworkCore;
using ProductPortal.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Pomelo.EntityFrameworkCore;

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
            optionsBuilder
        .UseMySql("Server=192.168.56.101; Port=3308; Database=PortalDataBase; Uid=apiuser; Pwd=database;", options => options.EnableRetryOnFailure());

            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
