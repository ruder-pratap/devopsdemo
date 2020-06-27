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
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _services;
        private readonly IProductServices productServices;

        public CategoryController(ICategoryServices services, IProductServices productServices)
        {
            this._services = services;
            this.productServices = productServices;
        }
        [Route("")]
        [Route("Category")]
        [Route("Category/Index")]
        public async Task<IActionResult> Index()
        {
            var data = await _services.GetCategoryAsync();

            return View(data);
        }

        [Route("[controller]/[action]/{id}")]
        [Route("Category/Details/{id}/", Name = "Categorydetails", Order = 2)]
        public async Task<IActionResult> Details(int id)
        {
            var data = await _services.GetCategoryByIdAsync(id);
            return View(data);
        }

        [Route("[controller]/[action]")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("[controller]/[action]")]
        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel model)
        {
            var data = await _services.CreateCategoryAsync(model);
            if (data.IsSuccess)
                return RedirectToAction("index");
            else
                return View();
        }


        [Route("[controller]/[action]/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var data = await _services.GetCategoryByIdAsync(id);
            if (data != null)
                return View(data);
            else
                return View("index");
        }

        [Route("[controller]/[action]/{id}")]
        [HttpPost]
        public async Task<IActionResult> Edit(CategoryViewModel model)
        {
            var data = await _services.EditCategoryByIdAsync(model);
            if (data.IsSuccess)
                return RedirectToAction("index");
            else
                return View();
        }

        [Route("[controller]/[action]/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _services.GetCategoryByIdAsync(id);
            if (data != null)
                return View(data);
            else
                return RedirectToAction("index");
        }

        [Route("[controller]/[action]/{Id}")]
        [HttpPost]
        public async Task<IActionResult> DeleteCategory(int Id)
        {
            var data = await _services.DeletetCategoryByIdAsync(Id);

            if (data.IsSuccess)
                return RedirectToAction("index");
            else
                return RedirectToAction("index");
        }
    }
}