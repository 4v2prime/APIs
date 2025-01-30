using System;
using System.Collections.Generic;

namespace API_Student.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string City { get; set; } = null!;

    public int Pincode { get; set; }
}
