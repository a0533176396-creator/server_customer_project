using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ProductsInSale
{
    public int ProductInSaleId { get; set; }

    public int? ProductId { get; set; }

    public int? SaleId { get; set; }

    public int? CountProduct { get; set; }

    public double? SumPriceThisProductInSale { get; set; }

    public bool? Enabled { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Salse ProductInSale { get; set; } = null!;
}
