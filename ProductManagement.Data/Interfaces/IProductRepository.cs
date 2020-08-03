using ProductManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Data.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product candidate);
        void Delete(int id);
        void Update(Product candidate);
        Product GetById(int id);
        List<Product> GetAll();
    }
}
