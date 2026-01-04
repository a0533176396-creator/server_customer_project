using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.function
{
    public static class productsInSaleFunction
    {
        static ShopProjetContext DB = new ShopProjetContext();
        //שליפה
        public static List<ProductsInSale> GetAllProductsInSales()
        {
            return DB.ProductsInSales.ToList();
        }
        //שליפה באמצעות ID
        public static ProductsInSale GetProductsInSaleById(string id)
        {
            return DB.ProductsInSales.Find(id);
        }
        //הוספה
        public static List<ProductsInSale> AddProductsInSale(ProductsInSale ProductsInSale)
        {
            DB.ProductsInSales.Add(ProductsInSale);
            DB.SaveChanges();
            return GetAllProductsInSales();
        }
        //עדכון
        public static List<ProductsInSale> UpdateProductsInSale(ProductsInSale ProductsInSale)
        {
            var existingProductsInSale = DB.ProductsInSales.Find(ProductsInSale.ProductInSaleId);
            if (existingProductsInSale != null)
            {
                existingProductsInSale.SaleId = ProductsInSale.SaleId;
                existingProductsInSale.ProductId = ProductsInSale.ProductId;
                existingProductsInSale.CountProduct = ProductsInSale.CountProduct;
                existingProductsInSale.SumPriceThisProductInSale = ProductsInSale.SumPriceThisProductInSale;
                existingProductsInSale.Enabled = ProductsInSale.Enabled;
                DB.SaveChanges();
            }
            return GetAllProductsInSales();
        }
        //מחיקה
        public static List<ProductsInSale> DeleteProductsInSale(string id)
        {
            var ProductsInSale = DB.ProductsInSales.Find(id);
            if (ProductsInSale != null)
            {
                DB.ProductsInSales.Remove(ProductsInSale);
                DB.SaveChanges();
            }
            return GetAllProductsInSales();
        }

    }
}
