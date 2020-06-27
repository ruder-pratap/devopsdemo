using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductPortal.Model;
using ProductPortal.Repository.CategoryRepository;

namespace ProductPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        [HttpPost("createcategory")]
        public async Task<IActionResult> CreateCategoryAsync(Category model)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoryRepository.CreateCategory(model);

                if (result.IsSuccess)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest("One or more validation errors occurred.");
        }

        [HttpGet("getallcategory")]
        public async Task<IActionResult> GetAllCategory()
        {

            if (ModelState.IsValid)
            {
                var result = await _categoryRepository.GetAllCategory();

                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest("Some properties are not valid");
        }

        [HttpGet("getcategory")]
        [Route("getcategory/{id:int}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {

            if (ModelState.IsValid)
            {
                var result = await _categoryRepository.GetCategoryByIdAsync(id);

                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest("Some properties are not valid");
        }

        [HttpPut("updatecategory")]
        public async Task<IActionResult> UpdateCategory(Category model)
        {

            if (ModelState.IsValid)
            {
                var result = await _categoryRepository.EditCategoryAsync(model);

                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest("Some properties are not valid");
        }

        [HttpDelete("categorydelete/{id:int}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {

            if (ModelState.IsValid)
            {
                var result = await _categoryRepository.DeletetCategoryAsync(id);

                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest("Some properties are not valid");
        }
    }
}