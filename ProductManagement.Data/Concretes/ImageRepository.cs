using ProductManagement.Data.Interfaces;
using ProductManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductManagement.Data.Concretes
{
    public class ImageRepository : IImageRepository
    {
        private readonly ProductManagementContext _context;

        public ImageRepository(ProductManagementContext context)
        {
            _context = context;
        }

        public int Add(Image image)
        {
            var foundImage = _context.Images.FirstOrDefault(i => i.ImageBase64.Equals(image.ImageBase64));

            if (foundImage == null)
            {
                _context.Images.Add(image);
                _context.SaveChanges();
                return image.Id;
            }
            else
            {
                return foundImage.Id;
            }
        }

        public void Delete(Image image)
        {
            _context.Images.Remove(image);
            _context.SaveChanges();
        }

        public Image GetByImageBase64(string imageBase64)
        {
            var image = _context.Images.FirstOrDefault(i => i.ImageBase64.Equals(imageBase64));

            if (image != null)
            {
                return image;
            }
            else
            {
                throw new Exception("Image not found");
            }
        }

        public List<Image> GetByIds(List<int> ids)
        {
            return _context.Images.Where(i => ids.Contains(i.Id)).ToList();
        }

        public List<Image> GetByImageBase64s(List<string> imageBase64s)
        {
            return _context.Images.Where(i => imageBase64s.Contains(i.ImageBase64)).ToList();
        }

        public List<Image> GetByProductId(int productId)
        {
            var productImages = _context.ProductImages.Where(pi => pi.ProductId == productId);
            var images = _context.Images.AsQueryable();

            return (
                        from productImage in productImages
                        join image in images on productImage.ImageId equals image.Id
                        select new Image 
                        { 
                            Id = image.Id,
                            ImageBase64 = image.ImageBase64
                        }
                    ).ToList();
        }
    }
}
