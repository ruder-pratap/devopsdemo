using Microsoft.EntityFrameworkCore;
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
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
