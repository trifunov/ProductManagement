using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductManagement.Data.Models
{
    public class ProductImage
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}
