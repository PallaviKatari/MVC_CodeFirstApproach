using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CFA.Models;

namespace MVC_CFA.Controllers
{
    public class EmployeeController : Controller
    {
        DepartmentEmployeecontext context = new DepartmentEmployeecontext();
        // GET: Department
        public ActionResult AddNewEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewEmployee(Employee employee)
        {
            //Binding of incoming values
            if (ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
            return View();
        }
    }
}
