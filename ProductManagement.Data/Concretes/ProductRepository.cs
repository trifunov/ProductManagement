using ProductManagement.Data.Interfaces;
using ProductManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductManagement.Data.Concretes
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductManagementContext _context;

        public ProductRepository(ProductManagementContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Products.Find(id);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Product not found");
            }
        }

        public void Update(Product productInput)
        {
            var product = _context.Products.Find(productInput.Id);

            if (product != null)
            {
                product.WarehouseId = productInput.WarehouseId;
                product.Description = productInput.Description;
                product.Price = productInput.Price;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Product not found");
            }
        }

        public Product GetById(int id)
        {
            var product = _context.Products.Find(id);

            if (product != null)
            {
                return product;
            }
            else
            {
                throw new Exception("Product not found");
            }
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
