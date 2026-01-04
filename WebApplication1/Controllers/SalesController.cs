using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;
using DAL.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        [HttpGet("GetAllSalse")]
        public List<SalseDTO> GetAllSales()
        {
            return functionOfSale.GetAllSales();
        }
        [HttpGet("GetSaleById/{id}")]
        public SalseDTO getSaleById(string id)
        {
            return functionOfSale.GetSaleById(id);
        }
        [HttpPost("AddSale")]
        public List<SalseDTO> AddSale(SalseDTO saleDTO)
        {
            return functionOfSale.AddSale(saleDTO);
        }
        [HttpPut("UpdateSale/{id}")]
        public List<SalseDTO> updateSale(SalseDTO saleDTO)
        {
            return functionOfSale.UpdateSale(saleDTO);
        }
        [HttpDelete("DeleteSale/{id}")]
        public List<SalseDTO> deleteSale(string id)
        {
            return functionOfSale.DeleteSale(id);
        }

    }
}
