﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Service.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int WarehouseId { get; set; }
        public decimal Price { get; set; }
    }
}
