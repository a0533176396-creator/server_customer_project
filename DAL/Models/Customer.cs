using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Customer
{
    public string CustomerId { get; set; } = null!;

    public string? CustomerFirstName { get; set; }

    public string? CustomerLastName { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public bool? IsManuy { get; set; }

    public bool? Enabled { get; set; }

    public virtual ICollection<Salse> Salses { get; set; } = new List<Salse>();
}
