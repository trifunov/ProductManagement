﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductManagement.Data.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
