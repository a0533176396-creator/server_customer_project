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
    public static class functionOfSale
    {
        //שליפה
        public static List<SalseDTO> GetAllSales()
        {
            List<Salse> list = salesFunction.GetAllSalses();
            List<SalseDTO> dtoList = AutoMapClass.ToSalesDTO(list);
            return dtoList;
        }
        //שליפה באמצעות מזהה
        public static SalseDTO GetSaleById(string tz)
        {
            Salse Salse = salesFunction.GetSalseById(tz);
            SalseDTO SalseDTO = AutoMapClass._Mapper.Map<Salse, SalseDTO>(Salse);
            return SalseDTO;
        }
        //הוספה
        public static List<SalseDTO> AddSale(SalseDTO SalseDTO)
        {
            Salse Salse = AutoMapClass._Mapper.Map<SalseDTO, Salse>(SalseDTO);
            List<Salse> list = salesFunction.AddSalse(Salse);
            List<SalseDTO> dtoList = AutoMapClass.ToSalesDTO(list);
            return dtoList;
        }
        //עדכון
        public static List<SalseDTO> UpdateSale(SalseDTO SalseDTO)
        {
            Salse Salse = AutoMapClass._Mapper.Map<SalseDTO, Salse>(SalseDTO);
            List<Salse> list = salesFunction.UpdateSalse(Salse);
            List<SalseDTO> dtoList = AutoMapClass.ToSalesDTO(list);
            return dtoList;
        }
        //מחיקה
        public static List<SalseDTO> DeleteSale(string tz)
        {
            List<Salse> list = salesFunction.DeleteSalse(tz);
            List<SalseDTO> dtoList = AutoMapClass.ToSalesDTO(list);
            return dtoList;
        }
    }
}
