using System;
using System.Collections.Generic;

namespace DAL.Models;

public class ProductDTO
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public DateOnly? LastDate { get; set; }

    public bool? Enabled { get; set; }

    public double? Price { get; set; }

}
