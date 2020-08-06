using ProductManagement.Data.Interfaces;
using ProductManagement.Data.Models;
using ProductManagement.Service.DTOs;
using ProductManagement.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Service.Concretes
{
    public class ProductManager : IProductManager
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductDTO productDto)
        {
            var product = new Product();
            product.Description = productDto.Description;
            product.WarehouseId = productDto.WarehouseId;
            product.Price = productDto.Price;
            _productRepository.Add(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public void Update(ProductDTO productDto)
        {
            var product = new Product();
            product.Id = productDto.Id;
            product.Description = productDto.Description;
            product.WarehouseId = productDto.WarehouseId;
            product.Price = productDto.Price;
            _productRepository.Update(product);
        }

        public List<ProductDTO> GetAll()
        {
            var productsDto = new List<ProductDTO>();
            var products = _productRepository.GetAll();

            foreach (var product in products)
            {
                var productDto = new ProductDTO();
                productDto.Id = product.Id;
                productDto.Description = product.Description;
                productDto.WarehouseId = product.WarehouseId;
                productDto.Price = product.Price;
                productsDto.Add(productDto);
            }

            return productsDto;
        }

        public ProductDTO GetById(int id)
        {
            var product = _productRepository.GetById(id);
            var productDto = new ProductDTO();
            productDto.Id = product.Id;
            productDto.Description = product.Description;
            productDto.WarehouseId = product.WarehouseId;
            productDto.Price = product.Price;

            return productDto;
        }
    }
}
