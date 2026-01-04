using System;
using System.Collections.Generic;

namespace DAL.Models;

public class WorkerDTO
{
    public string Tz { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public string? DateBeginWork { get; set; }

    public bool? IsManager { get; set; }

    public bool? Enabled { get; set; }

}
