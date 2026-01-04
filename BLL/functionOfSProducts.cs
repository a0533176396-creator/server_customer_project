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
    public static class functionOfSProducts
    {
        //שליפה
        public static List<ProductDTO> GetAllProducts()
        {
            List<Product> list = ProductsFunction.GetAllProducts();
            List<ProductDTO> dtoList = AutoMapClass.ToProductDTO(list);
            return dtoList;
        }
        //שליפה באמצעות מזהה
        public static ProductDTO GetProductById(string tz)
        {
            Product Product = ProductsFunction.GetProductById(tz);
            ProductDTO ProductDTO = AutoMapClass._Mapper.Map<Product, ProductDTO>(Product);
            return ProductDTO;
        }
        //הוספה
        public static List<ProductDTO> AddProduct(ProductDTO ProductDTO)
        {
            Product Product = AutoMapClass._Mapper.Map<ProductDTO, Product>(ProductDTO);
            List<Product> list = ProductsFunction.AddProduct(Product);
            List<ProductDTO> dtoList = AutoMapClass.ToProductDTO(list);
            return dtoList;
        }
        //עדכון
        public static List<ProductDTO> UpdateProduct(ProductDTO ProductDTO)
        {
            Product Product = AutoMapClass._Mapper.Map<ProductDTO, Product>(ProductDTO);
            List<Product> list = ProductsFunction.UpdateProduct(Product);
            List<ProductDTO> dtoList = AutoMapClass.ToProductDTO(list);
            return dtoList;
        }
        //מחיקה
        public static List<ProductDTO> DeleteProduct(string tz)
        {
            List<Product> list = ProductsFunction.DeleteProduct(tz);
            List<ProductDTO> dtoList = AutoMapClass.ToProductDTO(list);
            return dtoList;
        }
    }
}
