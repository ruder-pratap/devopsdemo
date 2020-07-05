using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using ProductPortal.Common;
using ProductPortal.Model;
using ProductPortal.ViewModel;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ProductPortal.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IMapper _mapper;
        public IConfiguration Configuration { get; }
        public ProductServices(IMapper mapper, IConfiguration configuration)
        {
            this._mapper = mapper;
            Configuration = configuration;
        }
        public async Task<UserManagerResponse> CreateProductAsync(ProductViewModel model)
        {
            if (model == null)
                return new UserManagerResponse{ 
                    IsSuccess = false,
                    Message = "Model is null",
                };

            var response = new UserManagerResponse();
            var data = new Product();
            _mapper.Map(model, data);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuration["core"]);
                var responseMessage = await client.PostAsJsonAsync<Product>("Products/createproduct", data);

                string result = responseMessage.Content.ReadAsStringAsync().Result;
                if (result != null)
                {
                    response = JsonConvert.DeserializeObject<UserManagerResponse>(result.ToString());
                    return response;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<UserManagerResponse> DeletetProductByIdAsync(int id)
        {
            if (id == 0)
                return new UserManagerResponse
                {
                    IsSuccess = false,
                    Message = "Id cant be 0",
                };

            var response = new UserManagerResponse();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuration["core"]);
                var responseMessage = await client.DeleteAsync($"Products/productdelete/{id.ToString()}");

                string result = responseMessage.Content.ReadAsStringAsync().Result;
                if (result != null)
                {
                    response = JsonConvert.DeserializeObject<UserManagerResponse>(result.ToString());
                    return response;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<UserManagerResponse> EditProductByIdAsync(ProductViewModel model)
        {
            if (model == null)
                return new UserManagerResponse
                {
                    IsSuccess = false,
                    Message = "Model is null",
                };

            UserManagerResponse response = null;
            var data = new Product();
            _mapper.Map(model, data);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuration["core"]);

                var responseMessage = await client.PutAsJsonAsync<Product>("Products/updateproduct", data);

                string result = responseMessage.Content.ReadAsStringAsync().Result;
                if (result != null)
                {
                    response = JsonConvert.DeserializeObject<UserManagerResponse>(result.ToString());
                    return response;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductAsync()
        {
            IEnumerable<Product> response = null;
            IEnumerable<ProductViewModel> productViewModel = new List<ProductViewModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuration["core"]);
                var httpContent = await client.GetAsync("Products/getallproducts");

                string result = httpContent.Content.ReadAsStringAsync().Result;

                if (result != null)
                {
                    response = JsonConvert.DeserializeObject<IEnumerable<Product>>(result.ToString());
                    _mapper.Map(response, productViewModel);
                    return productViewModel;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<ProductViewModel> GetSingleProductAsync(int id)
        {
            Product response = null;
            ProductViewModel productViewModel = new ProductViewModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuration["core"]);
                var httpContent = await client.GetAsync($"Products/getProduct/{id}");

                string result = httpContent.Content.ReadAsStringAsync().Result;
                if (result != null)
                {
                    response = JsonConvert.DeserializeObject<Product>(result.ToString());
                    _mapper.Map(response, productViewModel);
                    return productViewModel;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<ProductViewModel> GetSingleProductAsync(string name)
        {
            Product response = null;
            ProductViewModel productViewModel = new ProductViewModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Configuration["core"]);
                var httpContent = await client.GetAsync($"Products/SearchProduct/{name}");

                string result = httpContent.Content.ReadAsStringAsync().Result;
                if (result != null)
                {
                    response = JsonConvert.DeserializeObject<Product>(result.ToString());
                    _mapper.Map(response, productViewModel);
                    return productViewModel;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
