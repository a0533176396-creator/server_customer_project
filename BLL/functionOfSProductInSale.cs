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
    public static class functionOfProductInSale
    {
        //שליפה
        public static List<ProductsInSaleDTO> GetAllProductsInSales()
        {
            List<ProductsInSale> list = productsInSaleFunction.GetAllProductsInSales();
            List<ProductsInSaleDTO> dtoList = AutoMapClass.productsInSalseToDTO(list);
            return dtoList;
        }
        //שליפה באמצעות מזהה
        public static ProductsInSaleDTO GetProductsInSaleById(string tz)
        {
            ProductsInSale ProductsInSale = productsInSaleFunction.GetProductsInSaleById(tz);
            ProductsInSaleDTO ProductsInSaleDTO = AutoMapClass._Mapper.Map<ProductsInSale, ProductsInSaleDTO>(ProductsInSale);
            return ProductsInSaleDTO;
        }
        //הוספה
        public static List<ProductsInSaleDTO> AddProductsInSale(ProductsInSaleDTO ProductsInSaleDTO)
        {
            ProductsInSale ProductsInSale = AutoMapClass._Mapper.Map<ProductsInSaleDTO, ProductsInSale>(ProductsInSaleDTO);
            List<ProductsInSale> list = productsInSaleFunction.AddProductsInSale(ProductsInSale);
            List<ProductsInSaleDTO> dtoList = AutoMapClass.productsInSalseToDTO(list);
            return dtoList;
        }
        //עדכון
        public static List<ProductsInSaleDTO> UpdateProductsInSale(ProductsInSaleDTO ProductsInSaleDTO)
        {
            ProductsInSale ProductsInSale = AutoMapClass._Mapper.Map<ProductsInSaleDTO, ProductsInSale>(ProductsInSaleDTO);
            List<ProductsInSale> list = productsInSaleFunction.UpdateProductsInSale(ProductsInSale);
            List<ProductsInSaleDTO> dtoList = AutoMapClass.productsInSalseToDTO(list);
            return dtoList;
        }
        //מחיקה
        public static List<ProductsInSaleDTO> DeleteProductsInSale(string tz)
        {
            List<ProductsInSale> list = productsInSaleFunction.DeleteProductsInSale(tz);
            List<ProductsInSaleDTO> dtoList = AutoMapClass.productsInSalseToDTO(list);
            return dtoList;
        }
    }
}
