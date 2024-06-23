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
    }
}
