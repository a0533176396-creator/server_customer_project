using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Salse
{
    public int SaleId { get; set; }

    public string? WorkerId { get; set; }

    public string? CustomerId { get; set; }

    public DateOnly? DateSale { get; set; }

    public double? SumPrice { get; set; }

    public bool? Enabled { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ProductsInSale? ProductsInSale { get; set; }

    public virtual Worker? Worker { get; set; }
}
