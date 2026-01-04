using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace DTO.mapper
{
    public class AutoMapClass : AutoMapper.Profile
    {
        public static IMapper _Mapper;
        static AutoMapClass()
        {
            var config = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<EventGuestsTbl,EventGuestsDTO>();
                cfg.AddProfile<AutoMapClass>();

            });
            _Mapper = config.CreateMapper();
        }




        static ShopProjetContext DB = new ShopProjetContext();

        public AutoMapClass()
        {
            //המרה של מחלקת לקוחות
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();

            //המרה שחל מחלקת רכישות
            CreateMap<Salse, SalseDTO>();
            CreateMap<SalseDTO, Salse>();

            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();

            CreateMap<ProductsInSale, ProductsInSaleDTO>();
            CreateMap<ProductsInSaleDTO, ProductsInSale>();

            CreateMap<Worker, WorkerDTO>();
            CreateMap<WorkerDTO, Worker>();
        }
        public static List<WorkerDTO> MapWorkerListToDTO(List<Worker> workersList)
        {
            List<WorkerDTO> dataToReturn = new List<WorkerDTO>();

            foreach (Worker item in workersList)
            {
                WorkerDTO DTO = _Mapper.Map<Worker, WorkerDTO>(item);
                dataToReturn.Add(DTO);
            }
            return dataToReturn;
        }
        public static List<Worker> MapWorkerFromDtoToList(List<WorkerDTO> workersDTOList)
        {
            List<Worker> dataToReturn = new List<Worker>();
            foreach (WorkerDTO item in workersDTOList)
            {
                Worker DTO = _Mapper.Map<WorkerDTO, Worker>(item);
                dataToReturn.Add(DTO);
            }
            return dataToReturn;
        }
        public static List<ProductsInSaleDTO> productsInSalseToDTO(List<ProductsInSale> productsOnSalesList)
        {
            List<ProductsInSaleDTO> dataToReturn = new List<ProductsInSaleDTO>();

            foreach (ProductsInSale item in productsOnSalesList)
            {
                ProductsInSaleDTO DTO = _Mapper.Map<ProductsInSale, ProductsInSaleDTO>(item);
                dataToReturn.Add(DTO);
            }
            return dataToReturn;
        }
        public static List<ProductsInSale> productsInOrderFromDTO(List<ProductsInSaleDTO> productsOnSalesDTOList)
        {
            List<ProductsInSale> dataToReturn = new List<ProductsInSale>();
            foreach (ProductsInSaleDTO item in productsOnSalesDTOList)
            {
                ProductsInSale DTO = _Mapper.Map<ProductsInSaleDTO, ProductsInSale>(item);
                dataToReturn.Add(DTO);
            }
            return dataToReturn;
        }
        public static List<ProductDTO> ToProductDTO(List<Product> productsOnOrderList)
        {
            List<ProductDTO> dataToReturn = new List<ProductDTO>();

            foreach (Product item in productsOnOrderList)
            {
                ProductDTO DTO = _Mapper.Map<Product, ProductDTO>(item);
                dataToReturn.Add(DTO);
            }
            return dataToReturn;
        }
        public static List<Product> FromProductDTO(List<ProductDTO> productsDTOOnOrderList)
        {
            List<Product> dataToReturn = new List<Product>();
            foreach (ProductDTO item in productsDTOOnOrderList)
            {
                Product DTO = _Mapper.Map<ProductDTO, Product>(item);
                dataToReturn.Add(DTO);
            }
            return dataToReturn;
        }
        public static List<SalseDTO> ToSalesDTO(List<Salse> SalesOnSaleList)
        {
            List<SalseDTO> dataToReturn = new List<SalseDTO>();

            foreach (Salse item in SalesOnSaleList)
            {
                SalseDTO DTO = _Mapper.Map<Salse, SalseDTO>(item);
                dataToReturn.Add(DTO);
            }
            return dataToReturn;
        }
        public static List<Salse> FromSalesDTO(List<SalseDTO> SalesDTOOnSaleList)
        {
            List<Salse> dataToReturn = new List<Salse>();
            foreach (SalseDTO item in SalesDTOOnSaleList)
            {
                Salse DTO = _Mapper.Map<SalseDTO, Salse>(item);
                dataToReturn.Add(DTO);
            }
            return dataToReturn;
        }
        public static List<CustomerDTO> ToCustomerDTO(List<Customer> CustomersList)
        {
            List<CustomerDTO> dataToReturn = new List<CustomerDTO>();

            foreach (Customer item in CustomersList)
            {
                CustomerDTO DTO = _Mapper.Map<Customer, CustomerDTO>(item);
                dataToReturn.Add(DTO);
            }
            return dataToReturn;
        }
        public static List<Customer> FromCustomerDTO(List<CustomerDTO> CustomersDTOList)
        {
            List<Customer> dataToReturn = new List<Customer>();
            foreach (CustomerDTO item in CustomersDTOList)
            {
                Customer DTO = _Mapper.Map<CustomerDTO, Customer>(item);
                dataToReturn.Add(DTO);
            }
            return dataToReturn;
        }
    }
}
