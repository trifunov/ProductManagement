using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Service.DTOs
{
    public class ProductImagesDTO
    {
        public int ProductId { get; set; }
        public List<ImageDTO> Images { get; set; }
    }
}
