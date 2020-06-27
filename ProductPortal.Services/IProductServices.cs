using ProductPortal.Common;
using ProductPortal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Services
{
    public interface IProductServices
    {
        Task<UserManagerResponse> CreateProductAsync(ProductViewModel model);
        Task<IEnumerable<ProductViewModel>> GetProductAsync();
        Task<ProductViewModel> GetSingleProductAsync(int id);
        Task<ProductViewModel> GetSingleProductAsync(string name);
        Task<UserManagerResponse> EditProductByIdAsync(ProductViewModel model);
        Task<UserManagerResponse> DeletetProductByIdAsync(int id);

    }
}
