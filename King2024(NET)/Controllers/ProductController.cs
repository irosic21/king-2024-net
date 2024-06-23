using King2024_NET_.Business.Interfaces;
using King2024_NET_.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace King2024_NET_.Controllers
{
    [ApiController]
    [Route("api/product/")]
    public class ProductController
    {
        private readonly IProductServices _productServices;

        public ProductController(ProductServices productServices)
        {
            _productServices = productServices;
        }
    }
}
