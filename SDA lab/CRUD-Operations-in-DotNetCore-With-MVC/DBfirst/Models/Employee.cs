using System;
using System.Collections.Generic;

namespace DBfirst.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
    }
}
