using Microsoft.EntityFrameworkCore;
using ProductPortal.Common;
using ProductPortal.Model;
using ProductPortal.Repository.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<UserManagerResponse> CreateProduct(Product model)
        {
            if (model == null)
                throw new NullReferenceException("Model is null");

            var result = await dbContext.AddAsync(model);
            var v = await dbContext.SaveChangesAsync();
            if (result != null)
            {
                return new UserManagerResponse
                {
                    Message = "Product created sucessfully",
                    IsSuccess = true,
                };
            }

            return new UserManagerResponse
            {
                Message = "Product did not created",
                IsSuccess = false,
            };

        }

        public async Task<UserManagerResponse> DeletetProductAsync(int id)
        {
            if (id == 0)
                throw new NullReferenceException("Id cant be 0");
           
            var product = await dbContext.products.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            if (product != null)
            {
                dbContext.Entry(product).State = EntityState.Deleted;
                var result = await dbContext.SaveChangesAsync();
                if (result != 0)
                    return new UserManagerResponse
                    {
                        Message = "Product Deleted sucessfully",
                        IsSuccess = true,
                    };
            }

            return new UserManagerResponse
            {
                Message = "Product did not Deleted",
                IsSuccess = false,
            };
        }

        public async Task<UserManagerResponse> EditProductAsync(Product model)
        {
            if (model == null)
                throw new NullReferenceException("Model is null");
            
            var product = await dbContext.products.Where(x => x.Id == model.Id).AsNoTracking().FirstOrDefaultAsync();
            if(product != null)
            {
                product = model;
  
                dbContext.Entry(product).State = EntityState.Modified;
                var result = await dbContext.SaveChangesAsync();
                if(result != 0)
                    return new UserManagerResponse
                    {
                        Message = "Product updated sucessfully",
                        IsSuccess = true,
                    };
            }

            return new UserManagerResponse
            {
                Message = "Product did not updated",
                IsSuccess = false,
            };
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            IList<Product> products = null;

            products = await dbContext.products.ToListAsync<Product>();

            if (products.Count() == 0)
            {
                return null;
            }

            return products;
        }

        public async Task<Product> GetSingleProductAsync(int id)
        {
            Product products = null;

            products = await dbContext.products.FindAsync(id);

            if (products == null)
            {
                return null;
            }

            return products;
        }

        public async Task<Product> GetSingleProductAsync(string name)
        {
            Product products = null;

            products = await dbContext.products.Where(x=>x.Name == name).FirstOrDefaultAsync();

            if (products == null)
            {
                return null;
            }

            return products;
        }
    }
}
