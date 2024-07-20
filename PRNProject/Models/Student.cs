using System;
using System.Collections.Generic;

namespace PRNProject.Models;

public partial class Student
{
    public string RollNum { get; set; } = null!;

    public string? Name { get; set; }

    public string? Dob { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Class { get; set; }

    public string? Major { get; set; }

    public double? Gpa { get; set; }
}
