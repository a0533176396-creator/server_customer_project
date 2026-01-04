using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.function
{
    public static class workersFunction
    {
        static ShopProjetContext DB = new ShopProjetContext();
        //שליפה
        public static List<Worker> GetAllWorkers()
        {
            return DB.Workers.ToList();
        }
        //שליפה באמצעות ID
        public static Worker GetWorkerById(string id)
        {
            return DB.Workers.Find(id);
        }
        //הוספה
        public static List<Worker> AddWorker(Worker worker)
        {
            DB.Workers.Add(worker);
            DB.SaveChanges();
            return GetAllWorkers();
        }
        //עדכון
        public static List<Worker> UpdateWorker(Worker worker)
        {
            var existingWorker = DB.Workers.Find(worker.Tz);
            if (existingWorker != null)
            {
                existingWorker.FirstName = worker.FirstName;
                existingWorker.LastName = worker.LastName;
                existingWorker.Email = worker.Email;
                existingWorker.PhoneNumber = worker.PhoneNumber;
                existingWorker.Address = worker.Address;
                existingWorker.DateBeginWork = worker.DateBeginWork;
                existingWorker.IsManager = worker.IsManager;
                existingWorker.Enabled = worker.Enabled;
                DB.SaveChanges();
            }
            return GetAllWorkers();
        }
        //מחיקה
        public static List<Worker> DeleteWorker(string id)
        {
            var worker = DB.Workers.Find(id);
            if (worker != null)
            {
                DB.Workers.Remove(worker);
                DB.SaveChanges();
            }
            return GetAllWorkers();
        }

    }
}
