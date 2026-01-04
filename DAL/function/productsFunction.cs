using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.function
{
    public static class ProductsFunction
    {
        static ShopProjetContext DB = new ShopProjetContext();
        //שליפה
        public static List<Product> GetAllProducts()
        {
            return DB.Products.ToList();
        }
        //שליפה באמצעות ID
        public static Product GetProductById(string id)
        {
            return DB.Products.Find(id);
        }
        //הוספה
        public static List<Product> AddProduct(Product Product)
        {
            DB.Products.Add(Product);
            DB.SaveChanges();
            return GetAllProducts();
        }
        //עדכון
        public static List<Product> UpdateProduct(Product Product)
        {
            var existingProduct = DB.Products.Find(Product.ProductId);
            if (existingProduct != null)
            {
                existingProduct.ProductName = Product.ProductName;
                existingProduct.Price = Product.Price;
                existingProduct.Enabled = Product.Enabled;
                existingProduct.LastDate = Product.LastDate;
                DB.SaveChanges();
            }
            return GetAllProducts();
        }
        //מחיקה
        public static List<Product> DeleteProduct(string id)
        {
            var Product = DB.Products.Find(id);
            if (Product != null)
            {
                DB.Products.Remove(Product);
                DB.SaveChanges();
            }
            return GetAllProducts();
        }

    }
}
