using ProductManagement.Data.Interfaces;
using ProductManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductManagement.Data.Concretes
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly ProductManagementContext _context;

        public ProductImageRepository(ProductManagementContext context)
        {
            _context = context;
        }

        public void Add(ProductImage productImage)
        {
            var foundProductImage = _context.ProductImages.FirstOrDefault(pi => pi.ProductId == productImage.ProductId && pi.ImageId == productImage.ImageId);

            if (foundProductImage == null)
            {
                _context.ProductImages.Add(productImage);
                _context.SaveChanges();
            }
        }

        public void Delete(ProductImage productImage)
        {
            _context.ProductImages.Remove(productImage);
            _context.SaveChanges();
        }

        public List<ProductImage> GetByProductId(int productId)
        {
            return _context.ProductImages.Where(pi => pi.ProductId == productId).ToList();
        }
    }
}
