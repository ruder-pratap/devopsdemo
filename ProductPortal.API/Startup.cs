using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProductPortal.Repository.MyDbContext;
using Microsoft.EntityFrameworkCore;
using ProductPortal.Repository;
using ProductPortal.Repository.CategoryRepository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MySql.Data.EntityFrameworkCore.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace ProductPortal.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddDbContextPool<AppDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("DBConnection")
            //     , MySQLOptionsAction: sqlOptions =>
            //     {
            //         sqlOptions.ExecutionStrategy(c => new MySqlRetryingExecutionStrategy(c));
            //     }
            //     ));

            //services.AddDbContextPool<AppDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("DBConnection")));
            var host = Configuration["DBHOST"]??"localhost";
            var port = Configuration["DBPORT"]??"3306";
            var password = Configuration["DBPASSWORD"]??"database";

            // services.AddDbContext<AppDbContext>(opt =>
            // {
            //     opt.UseMySQL($"server={host}; userid=root; pwd={password}; port={port}; database=PortalDataBase;");
            // } 
            // );

            services.AddDbContext<AppDbContext>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
