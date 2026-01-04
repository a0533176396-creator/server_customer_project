using BLL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet("getAllCustomers")]
        public List<CustomerDTO> GetAllCustomers()
        {
            return functionOfCustomers.GetAllCustomers();
        }
        [HttpGet("getCustomerById/{tz}")]
        public CustomerDTO getCustomerById(string tz)
        {
            return functionOfCustomers.GetCustomerById(tz);
        }
        [HttpPost("addCustomer")]
        public List<CustomerDTO> AddCustomer(CustomerDTO customerDTO)
        {
            return functionOfCustomers.AddCustomer(customerDTO);
        }
        [HttpPut("updateCustomer/{tz}")]
        public bool updateCustomer(CustomerDTO customerDTO)
        {
            return functionOfCustomers.UpdateCustomer(customerDTO);
        }
        [HttpDelete("deleteCustomer/{tz}")]
        public List<CustomerDTO> deleteCustomer(string tz)
        {
            return functionOfCustomers.DeleteCustomer(tz);
        }
    }
}
