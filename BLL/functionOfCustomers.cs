using DAL.function;
using DAL.Models;
using DTO.mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class functionOfCustomers
    {
        //שליפה
        public static List<CustomerDTO> GetAllCustomers()
        {
            List<Customer> list = customersFunction.GetAllCustomers();
            List<CustomerDTO> dtoList = AutoMapClass.ToCustomerDTO(list);
            return dtoList;
        }
        //שליפה באמצעות מזהה
        public static CustomerDTO GetCustomerById(string tz)
        {
            Customer Customer = customersFunction.GetCustomerById(tz);
            CustomerDTO CustomerDTO = AutoMapClass._Mapper.Map<Customer, CustomerDTO>(Customer);
            return CustomerDTO;
        }
        //הוספה
        public static List<CustomerDTO> AddCustomer(CustomerDTO CustomerDTO)
        {
            Customer Customer = AutoMapClass._Mapper.Map<CustomerDTO, Customer>(CustomerDTO);
            List<Customer> list = customersFunction.AddCustomer(Customer);
            List<CustomerDTO> dtoList = AutoMapClass.ToCustomerDTO(list);
            return dtoList;
        }
        //עדכון
        public static bool UpdateCustomer(CustomerDTO CustomerDTO)
        {
            Customer Customer = AutoMapClass._Mapper.Map<CustomerDTO, Customer>(CustomerDTO);
            customersFunction.UpdateCustomer(Customer);
            return true;
        }
        //מחיקה
        public static List<CustomerDTO> DeleteCustomer(string tz)
        {
            List<Customer> list = customersFunction.DeleteCustomer(tz);
            List<CustomerDTO> dtoList = AutoMapClass.ToCustomerDTO(list);
            return dtoList;
        }
    }
}
