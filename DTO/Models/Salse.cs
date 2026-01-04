using System;
using System.Collections.Generic;

namespace DAL.Models;

public class SalseDTO
{
    public int SaleId { get; set; }

    public string? WorkerId { get; set; }

    public string? CustomerId { get; set; }

    public DateOnly? DateSale { get; set; }

    public double? SumPrice { get; set; }

    public bool? Enabled { get; set; }

}
