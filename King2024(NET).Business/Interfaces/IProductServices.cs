using King2024_NET_.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King2024_NET_.Business.Interfaces
{
    public interface IProductServices
    {
        public Task<List<Product>> GetAllProductsAsync();
        public Task<Product> GetProductByIdAsync(int id);
        public Task<List<Product>> SearchProductsAsync(string searchText);
        public Task<List<Product>> FilterProductsAsync(string category, decimal? minPrice, decimal? maxPrice);
    }
}
