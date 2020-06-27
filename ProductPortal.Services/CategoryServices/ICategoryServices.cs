using ProductPortal.Common;
using ProductPortal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Services.CategoryServices
{
    public interface ICategoryServices
    {
        Task<UserManagerResponse> CreateCategoryAsync(CategoryViewModel model);
        Task<IEnumerable<CategoryViewModel>> GetCategoryAsync();
        Task<CategoryViewModel> GetCategoryByIdAsync(int id);
        Task<UserManagerResponse> EditCategoryByIdAsync(CategoryViewModel model);
        Task<UserManagerResponse> DeletetCategoryByIdAsync(int id);
    }
}
