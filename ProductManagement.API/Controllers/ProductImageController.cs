using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Service.DTOs;
using ProductManagement.Service.Interfaces;

namespace ProductManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductImageController : ControllerBase
    {
        private readonly IProductImageManager _productImageManager;

        public ProductImageController(IProductImageManager productImageManager)
        {
            _productImageManager = productImageManager;
        }

        [HttpPost]
        public IActionResult Add([FromBody]ImageUploadDTO imageUploadDto)
        {
            try
            {
                _productImageManager.Add(imageUploadDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Delete(int productId, int imageId)
        {
            try
            {
                _productImageManager.Delete(productId, imageId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetByProductId(int productId)
        {
            try
            {
                return Ok(_productImageManager.GetByProductId(productId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}