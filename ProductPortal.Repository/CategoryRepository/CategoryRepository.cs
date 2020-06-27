using Microsoft.EntityFrameworkCore;
using ProductPortal.Common;
using ProductPortal.Model;
using ProductPortal.Repository.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Repository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext dbContext;

        public CategoryRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<UserManagerResponse> CreateCategory(Category model)
        {
            if (model == null)
                throw new NullReferenceException("Model is null");

            var result = await dbContext.AddAsync(model);
            var v = await dbContext.SaveChangesAsync();
            if (result != null)
            {
                return new UserManagerResponse
                {
                    Message = "Category created sucessfully",
                    IsSuccess = true,
                };
            }

            return new UserManagerResponse
            {
                Message = "Category did not created",
                IsSuccess = false,
            };
        }

        public async Task<UserManagerResponse> DeletetCategoryAsync(int id)
        {
            if (id == 0)
                throw new NullReferenceException("Id cant be 0");

            var category = await dbContext.categories.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            if (category != null)
            {
                dbContext.Entry(category).State = EntityState.Deleted;
                var result = await dbContext.SaveChangesAsync();
                if (result != 0)
                    return new UserManagerResponse
                    {
                        Message = "Category Deleted sucessfully",
                        IsSuccess = true,
                    };
            }

            return new UserManagerResponse
            {
                Message = "Category did not Deleted",
                IsSuccess = false,
            };
        }

        public async Task<UserManagerResponse> EditCategoryAsync(Category model)
        {
            if (model == null)
                throw new NullReferenceException("Model is null");

            var category = await dbContext.categories.Where(x => x.Id == model.Id).AsNoTracking().FirstOrDefaultAsync();
            if (category != null)
            {
                category = model;

                dbContext.Entry(category).State = EntityState.Modified;
                var result = await dbContext.SaveChangesAsync();
                if (result != 0)
                    return new UserManagerResponse
                    {
                        Message = "category updated sucessfully",
                        IsSuccess = true,
                    };
            }

            return new UserManagerResponse
            {
                Message = "category did not updated",
                IsSuccess = false,
            };
        }

        public async Task<IEnumerable<Category>> GetAllCategory()
        {
            IList<Category> category = null;

            category = await dbContext.categories.ToListAsync<Category>();

            if (category.Count() == 0)
            {
                return null;
            }

            return category;
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            Category category = null;

            category = await dbContext.categories.FindAsync(id);

            if (category == null)
            {
                return null;
            }

            return category;
        }
    }
}
