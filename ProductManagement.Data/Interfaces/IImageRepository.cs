using ProductManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Data.Interfaces
{
    public interface IImageRepository
    {
        int Add(Image image);
        void Delete(Image image);
        Image GetByImageBase64(string imageBase64);
        List<Image> GetByIds(List<int> ids);
        List<Image> GetByImageBase64s(List<string> imageBase64s);
        List<Image> GetByProductId(int productId);
    }
}
