using System;
using System.Collections.Generic;

namespace UniversityWebApp.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public string? TeacherName { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? Subject { get; set; }
}
