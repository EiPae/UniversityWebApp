using System;
using System.Collections.Generic;

namespace UniversityWebApp.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? Gender { get; set; }

    public string? Coure { get; set; }

    public string? Address { get; set; }
}
