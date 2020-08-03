using ProductManagement.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Service.Interfaces
{
    public interface IProductManager
    {
        void Add(ProductDTO productDto);
        void Delete(int id);
        void Update(ProductDTO productDto);
        ProductDTO GetById(int id);
        List<ProductDTO> GetAll();
    }
}
