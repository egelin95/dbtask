using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Model
{
    public partial class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
