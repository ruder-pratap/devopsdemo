using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductPortal.Services;
using ProductPortal.Services.CategoryServices;
using ProductPortal.ViewModel;

namespace ProductPortal.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _services;
        private readonly ICategoryServices _categoryServices;

        public ProductController(IProductServices services, ICategoryServices categoryServices)
        {
            this._services = services;
            this._categoryServices = categoryServices;
        }
       
        [Route("Product")]
        [Route("Product/Index")]
        public async Task<IActionResult> Index()
        {
            var data = await _services.GetProductAsync();
            return View(data);
        }

        [Route("[controller]/[action]/{id}")]
        [Route("Product/Details/{id}/", Name = "productdetails", Order = 2)]
        public async Task<IActionResult> Details(int id)
        {
            var data = await _services.GetSingleProductAsync(id);
            return View(data);
        }

        [Route("[controller]/[action]")]
        public async Task<IActionResult> Create()
        {
            var productViewModel = new ProductViewModel();
            var data = await _categoryServices.GetCategoryAsync();
            productViewModel.category = data.ToList();
            return View(productViewModel);
        }

        [Route("[controller]/[action]")]
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            var data = await _services.CreateProductAsync(model);

            if (data.IsSuccess)
                return RedirectToAction("index");
            else
                return View();
        }


        [Route("[controller]/[action]/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var productViewModel = await _services.GetSingleProductAsync(id);
            var data = await _categoryServices.GetCategoryAsync();
            productViewModel.category = data.ToList();
            if (data != null)
                return View(productViewModel);
            else
                return View("index");
        }

        [Route("[controller]/[action]/{id}")]
        [HttpPost]
        public async Task<IActionResult> Edit(ProductViewModel model)
        {
            var data = await _services.EditProductByIdAsync(model);
            if (data.IsSuccess)
                return RedirectToAction("index");
            else
                return View();
        }

        [Route("[controller]/[action]/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _services.GetSingleProductAsync(id);
            if (data != null)
                return View(data);
            else
                return RedirectToAction("index");
        }

        [Route("[controller]/[action]/{Id}")]
        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int Id)
        {
            var data = await _services.DeletetProductByIdAsync(Id);

            if (data.IsSuccess)
                return RedirectToAction("index");
            else
                return RedirectToAction("index");
        }

        [Route("SearchProduct")]
        [Route("[controller]/[action]/{name?}")]
        [HttpPost]
        public async Task<IActionResult> SearchProduct(string name)
        {
            var data = await _services.GetSingleProductAsync(name);
            return View("Details", data);
        }
    }
}