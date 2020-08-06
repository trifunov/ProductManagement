using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Service.DTOs
{
    public class ProductImageDTO
    {
        public int ProductId { get; set; }
        public ImageDTO Image { get; set; }
    }
}
