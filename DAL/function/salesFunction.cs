using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.function
{
    public static class salesFunction
    {
        static ShopProjetContext DB = new ShopProjetContext();
        //שליפה
        public static List<Salse> GetAllSalses()
        {
            return DB.Salses.ToList();
        }
        //שליפה באמצעות ID
        public static Salse GetSalseById(string id)
        {
            return DB.Salses.Find(id);
        }
        //הוספה
        public static List<Salse> AddSalse(Salse Salse)
        {
            DB.Salses.Add(Salse);
            DB.SaveChanges();
            return GetAllSalses();
        }
        //עדכון
        public static List<Salse> UpdateSalse(Salse Salse)
        {
            var existingSalse = DB.Salses.Find(Salse.SaleId);
            if (existingSalse != null)
            {
                existingSalse.DateSale = Salse.DateSale;
                existingSalse.CustomerId = Salse.CustomerId;
                existingSalse.WorkerId = Salse.WorkerId;
                existingSalse.SumPrice = Salse.SumPrice;
                existingSalse.Enabled = Salse.Enabled;
                DB.SaveChanges();
            }
            return GetAllSalses();
        }
        //מחיקה
        public static List<Salse> DeleteSalse(string id)
        {
            var Salse = DB.Salses.Find(id);
            if (Salse != null)
            {
                DB.Salses.Remove(Salse);
                DB.SaveChanges();
            }
            return GetAllSalses();
        }

    }
}
