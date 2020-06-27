using ProductPortal.Common;
using ProductPortal.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Repository.CategoryRepository
{
   public interface ICategoryRepository
    {
        Task<UserManagerResponse> CreateCategory(Category model);
        Task<IEnumerable<Category>> GetAllCategory();
        Task<Category> GetCategoryByIdAsync(int id);
        Task<UserManagerResponse> EditCategoryAsync(Category model);
        Task<UserManagerResponse> DeletetCategoryAsync(int id);
    }
}
