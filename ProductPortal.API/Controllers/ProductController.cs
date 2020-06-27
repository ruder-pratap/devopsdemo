using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductPortal.Model;
using ProductPortal.Repository;

namespace ProductPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;
      
        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [HttpPost("createproduct")]
        public async Task<IActionResult> CreateProductAsync(Product model)
        {
            if (ModelState.IsValid)
            {
                var result = await productRepository.CreateProduct(model);

                if (result.IsSuccess)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest("One or more validation errors occurred.");
        }

        [HttpGet("getallproducts")]
        public async Task<IActionResult> GetAllProducts()
        {

            if (ModelState.IsValid)
            {
                var result = await productRepository.GetAllProduct();

                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest("Some properties are not valid");
        }

        [HttpGet("getProduct")]
        [Route("getProduct/{id:int}")]
        public async Task<IActionResult> GetProductById(int id)
        {

            if (ModelState.IsValid)
            {
                var result = await productRepository.GetSingleProductAsync(id);

                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest("Some properties are not valid");
        }

        [HttpPut("updateproduct")]
        public async Task<IActionResult> UpdateProducts(Product model)
        {

            if (ModelState.IsValid)
            {
                var result = await productRepository.EditProductAsync(model);

                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest("Some properties are not valid");
        }
        
        [HttpDelete("productdelete/{id:int}")]
        public async Task<IActionResult> DeleteProducts(int id)
        {

            if (ModelState.IsValid)
            {
                var result = await productRepository.DeletetProductAsync(id);

                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest("Some properties are not valid");
        }

        [HttpGet("/Product/SearchProduct/{name}")]
        [Route("SearchProduct/{name}")]
        public async Task<IActionResult> SearchProductByName(string name)
        {

            if (ModelState.IsValid)
            {
                var result = await productRepository.GetSingleProductAsync(name);

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