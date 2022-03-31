using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_CFA.Models
{
    public class DepartmentEmployeecontext:DbContext
    {
        public DepartmentEmployeecontext():base("MyConnection")
        {

        }
        public DbSet<Employee> Employees { get; set;}
        public DbSet<Department> Departments { get; set;}
    }
}