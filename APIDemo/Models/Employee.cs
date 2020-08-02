using System;
using System.Collections.Generic;

namespace APIDemo.Models
{
    public partial class Employee
    {
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public DateTime JoinDate { get; set; }
        public string Designation { get; set; }
        public int? Salary { get; set; }
    }
}
