using King2024_NET_.Business.Interfaces;
using King2024_NET_.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
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

        public async Task<List<Product>> FilterProductsAsync(string category, decimal? minPrice, decimal? maxPrice)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ProductResponseDTO>(url);
            return response.Products.Select(dto => new Product
            {
                Id = dto.Id,
                Name = dto.Title,
                Price = dto.Price,
                ShortDescription = dto.Description.Length > 100 ? dto.Description.Substring(0, 100) : dto.Description,
                Category = dto.Category,
                Image = dto.Thumbnail
            }).ToList();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<ProductDTO>(url + id);
            var product = new Product
            {
                Id = response.Id,
                Name = response.Title,
                Price = response.Price,
                ShortDescription = response.Description,
                Category = response.Category,
                Image = response.Thumbnail
            };
            return product;
        }

        public async Task<List<Product>> SearchProductsAsync(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}
