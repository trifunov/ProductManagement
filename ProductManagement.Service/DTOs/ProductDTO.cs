using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Service.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}
