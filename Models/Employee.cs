using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CFA.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public Department Department { get; set; }
    }
}