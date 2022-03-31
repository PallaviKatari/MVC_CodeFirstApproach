using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CFA.Models;

namespace MVC_CFA.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentEmployeecontext context=new DepartmentEmployeecontext();
        // GET: Department
        public ActionResult AddNewDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewDepartment(Department department)
        {
            //Binding of incoming values
            if(ModelState.IsValid)
            {
                context.Departments.Add(department);
                context.SaveChanges();
            }
            return View();
        }
    }
}