using BLL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsInSalesController : ControllerBase
    {
        [HttpGet("GetAllProductsInSales")]
        public List<ProductsInSaleDTO> GetAllProductsInSales()
        {
            return functionOfProductInSale.GetAllProductsInSales();
        }
        [HttpGet("GetProductsInSaleById/{tz}")]
        public ProductsInSaleDTO getProductsInSaleById(string tz)
        {
            return functionOfProductInSale.GetProductsInSaleById(tz);
        }
        [HttpPost("AddProductsInSale")]
        public List<ProductsInSaleDTO> AddProductsInSale(ProductsInSaleDTO productsInSaleDTO)
        {
            return functionOfProductInSale.AddProductsInSale(productsInSaleDTO);
        }
        [HttpPut("UpdateProductsInSale/{tz}")]
        public List<ProductsInSaleDTO> updateProductsInSale(ProductsInSaleDTO productsInSaleDTO)
        {
            return functionOfProductInSale.UpdateProductsInSale(productsInSaleDTO);
        }
        [HttpDelete("DeleteProductsInSale/{tz}")]
        public List<ProductsInSaleDTO> deleteProductsInSale(string tz)
        {
            return functionOfProductInSale.DeleteProductsInSale(tz);
        }
    }
}
