using System;
using System.Collections.Generic;

namespace DAL.Models;

public class ProductsInSaleDTO
{
    public int ProductInSaleId { get; set; }

    public int? ProductId { get; set; }

    public int? SaleId { get; set; }

    public int? CountProduct { get; set; }

    public double? SumPriceThisProductInSale { get; set; }

    public bool? Enabled { get; set; }


}
