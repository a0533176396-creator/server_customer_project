using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.function
{
    public static class customersFunction
    {
        static ShopProjetContext DB = new ShopProjetContext();
        //שליפה
        public static List<Customer> GetAllCustomers()
        {
            return DB.Customers.ToList();
        }
        //שליפה באמצעות ID
        public static Customer GetCustomerById(string id)
        {
            return DB.Customers.Find(id);
        }
        //הוספה
        public static List<Customer> AddCustomer(Customer Customer)
        {
            DB.Customers.Add(Customer);
            DB.SaveChanges();
            return GetAllCustomers();
        }
        //עדכון
        public static void UpdateCustomer(Customer Customer)
        {
            var existingCustomer = DB.Customers.Find(Customer.CustomerId);
            if (existingCustomer != null)
            {
                existingCustomer.CustomerFirstName = Customer.CustomerFirstName;
                existingCustomer.CustomerLastName = Customer.CustomerLastName;
                existingCustomer.Email = Customer.Email;
                existingCustomer.PhoneNumber = Customer.PhoneNumber;
                existingCustomer.Address = Customer.Address;
                existingCustomer.IsManuy = Customer.IsManuy;
                existingCustomer.Enabled = Customer.Enabled;
                DB.SaveChanges();
            }
            //return GetAllCustomers();
        }
        //מחיקה
        public static List<Customer> DeleteCustomer(string id)
        {
            var Customer = DB.Customers.Find(id);
            if (Customer != null)
            {
                DB.Customers.Remove(Customer);
                DB.SaveChanges();
            }
            return GetAllCustomers();
        }

    }
}
