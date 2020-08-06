using ProductManagement.Data.Interfaces;
using ProductManagement.Data.Models;
using ProductManagement.Service.DTOs;
using ProductManagement.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductManagement.Service.Concretes
{
    public class ProductImageManager : IProductImageManager
    {
        private readonly IProductImageRepository _productImageRepository;
        private readonly IImageRepository _imageRepository;

        public ProductImageManager(IProductImageRepository productImageRepository, IImageRepository imageRepository)
        {
            _productImageRepository = productImageRepository;
            _imageRepository = imageRepository;
        }

        public void Add(ImageUploadDTO imageUploadDto)
        {
            var imageId = _imageRepository.Add(new Image 
            { 
                ImageBase64 = imageUploadDto.Image
            });

            _productImageRepository.Add(new ProductImage 
            { 
                ProductId = imageUploadDto.ProductId, 
                ImageId = imageId 
            });
        }

        public void Delete(int productId, int imageId)
        {
            _productImageRepository.Delete(new ProductImage
            {
                ProductId = productId,
                ImageId = imageId
            });
        }

        public ProductImagesDTO GetByProductId(int productId)
        {
            var imagesDto = new List<ImageDTO>();
            var productImagesDto = new ProductImagesDTO() { ProductId = productId };
            var images = _imageRepository.GetByProductId(productId);

            foreach (var image in images)
            {
                var imageDto = new ImageDTO();
                imageDto.Id = image.Id;
                imageDto.ImageBase64  = image.ImageBase64;
                imagesDto.Add(imageDto);
            }

            productImagesDto.Images = imagesDto;
            return productImagesDto;
        }
    }
}
