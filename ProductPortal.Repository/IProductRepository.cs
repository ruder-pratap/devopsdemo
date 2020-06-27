using ProductPortal.Common;
using ProductPortal.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductPortal.Repository
{
    public interface IProductRepository
    {
        Task<UserManagerResponse> CreateProduct(Product model);
        Task<IEnumerable<Product>> GetAllProduct();
        Task<Product> GetSingleProductAsync(int id);
        Task<Product> GetSingleProductAsync(string name);
        Task<UserManagerResponse> EditProductAsync(Product model);
        Task<UserManagerResponse> DeletetProductAsync(int id);
    }
}
