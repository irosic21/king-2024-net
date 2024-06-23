using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King2024_NET_.Data.Models
{
    public class ProductResponseDTO
    {
        public List<ProductDTO> Products { get; set; }
        public int Total { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }
}
