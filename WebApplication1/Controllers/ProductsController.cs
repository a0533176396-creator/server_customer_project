using BLL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("GetAllProducts")]
        public List<ProductDTO> GetAllProducts()
        {
            return functionOfSProducts.GetAllProducts();
        }
        [HttpGet("GetProductById/{tz}")]
        public ProductDTO getProductById(string tz)
        {
            return functionOfSProducts.GetProductById(tz);
        }
        [HttpPost("AddProduct")]
        public List<ProductDTO> AddProduct(ProductDTO productDTO)
        {
            return functionOfSProducts.AddProduct(productDTO);
        }
        [HttpPut("UpdateProduct/{tz}")]
        public List<ProductDTO> updateProduct(ProductDTO productDTO)
        {
            return functionOfSProducts.UpdateProduct(productDTO);
        }
        [HttpDelete("DeleteProduct/{tz}")]
        public List<ProductDTO> deleteProduct(string tz)
        {
            return functionOfSProducts.DeleteProduct(tz);
        }
    }
}
