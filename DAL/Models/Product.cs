using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public DateOnly? LastDate { get; set; }

    public bool? Enabled { get; set; }

    public double? Price { get; set; }

    public virtual ICollection<ProductsInSale> ProductsInSales { get; set; } = new List<ProductsInSale>();
}
