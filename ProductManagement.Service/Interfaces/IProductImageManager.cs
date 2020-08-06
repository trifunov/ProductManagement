using ProductManagement.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Service.Interfaces
{
    public interface IProductImageManager
    {
        void Add(ImageUploadDTO imageUploadDto);
        void Delete(int productId, int imageId);
        ProductImagesDTO GetByProductId(int productId);
    }
}
