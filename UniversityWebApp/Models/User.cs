using System;
using System.Collections.Generic;

namespace UniversityWebApp.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? PhoneNumber { get; set; }

    public string? Address { get; set; }
}
