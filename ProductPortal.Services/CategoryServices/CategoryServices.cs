using AutoMapper;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ProductPortal.Common;
using ProductPortal.Model;
using ProductPortal.ViewModel;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProductPortal.Services.CategoryServices
{
    public class CategoryServices : ICategoryServices
    {
        private readonly IMapper _mapper;
        public IConfiguration Configuration { get; }
        public CategoryServices(IMapper mapper, IConfiguration configuration)
        {
            this._mapper = mapper;
            Configuration = configuration;
        }
        public async Task<UserManagerResponse> CreateCategoryAsync(CategoryViewModel model)
        {
            if (model == null)
                return new UserManagerResponse
                {
                    IsSuccess = false,
                    Message = "Model is null",
                };

            var response = new UserManagerResponse();
            var data = new Category();
            _mapper.Map(model, data);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56562/api/");
                var responseMessage = await client.PostAsJsonAsync<Category>("Category/createcategory", data);

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

        public async Task<UserManagerResponse> DeletetCategoryByIdAsync(int id)
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
                client.BaseAddress = new Uri("http://localhost:56562/api/");
                var responseMessage = await client.DeleteAsync($"Category/categorydelete/{id.ToString()}");

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

        public async Task<UserManagerResponse> EditCategoryByIdAsync(CategoryViewModel model)
        {
            if (model == null)
                return new UserManagerResponse
                {
                    IsSuccess = false,
                    Message = "Model is null",
                };

            UserManagerResponse response = null;
            var data = new Category();
            _mapper.Map(model, data);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56562/api/");

                var responseMessage = await client.PutAsJsonAsync<Category>("category/updatecategory", data);

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

        public async Task<IEnumerable<CategoryViewModel>> GetCategoryAsync()
        {
            IEnumerable<Category> response = null;
            IEnumerable<CategoryViewModel> categoryViewModel = new List<CategoryViewModel>();
            var url = Configuration["core"];
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56562/api/");
                var httpContent = await client.GetAsync("Category/getallcategory");

                string result = httpContent.Content.ReadAsStringAsync().Result;

                if (result != null)
                {
                    response = JsonConvert.DeserializeObject<IEnumerable<Category>>(result.ToString());
                    _mapper.Map(response, categoryViewModel);
                    return categoryViewModel;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<CategoryViewModel> GetCategoryByIdAsync(int id)
        {
            Category response = null;
            CategoryViewModel categoryViewModel = new CategoryViewModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56562/api/");
                var httpContent = await client.GetAsync($"Category/getcategory/{id}");

                string result = httpContent.Content.ReadAsStringAsync().Result;
                if (result != null)
                {
                    response = JsonConvert.DeserializeObject<Category>(result.ToString());
                    _mapper.Map(response, categoryViewModel);
                    return categoryViewModel;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
