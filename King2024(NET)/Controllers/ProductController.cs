﻿using King2024_NET_.Business.Interfaces;
using King2024_NET_.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace King2024_NET_.Controllers
{
    [ApiController]
    [Route("api/product/")]
    public class ProductController: ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(ProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productServices.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productServices.GetProductByIdAsync(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchProducts([FromQuery] string searchText)
        {
            if (searchText == null) return BadRequest();
            var products = await _productServices.SearchProductsAsync(searchText);
            return Ok(products);
        }

        [HttpGet("filter")]
        public async Task<IActionResult> FilterProducts([FromQuery] string category, [FromQuery] decimal? minPrice, [FromQuery] decimal? maxPrice)
        {
            var products = await _productServices.FilterProductsAsync(category, minPrice, maxPrice);
            return Ok(products);
        }
    }
}
