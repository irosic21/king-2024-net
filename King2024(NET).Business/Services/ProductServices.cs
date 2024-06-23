using King2024_NET_.Business.Interfaces;
using King2024_NET_.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King2024_NET_.Business.Services
{
    public class ProductServices : IProductServices
    {
        private readonly HttpClient _httpClient;
        private string url = "https://dummyjson.com/products/";

        public ProductServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<List<Product>> FilterProductsAsync(string category, decimal? minPrice, decimal? maxPrice)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> SearchProductsAsync(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}
