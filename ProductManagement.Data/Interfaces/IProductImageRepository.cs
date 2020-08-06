using ProductManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Data.Interfaces
{
    public interface IProductImageRepository
    {
        void Add(ProductImage productImage);
        void Delete(ProductImage productImage);
        List<ProductImage> GetByProductId(int productId);
    }
}
