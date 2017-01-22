using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using MvcApplication1.ViewModel;

namespace MvcApplication1.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public string Index()
        {
            return "Hello Wassup";
            //return View();
        }
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;
           // ViewData["Employee"] = emp;
            return View("MyView",emp);
        }
        public ActionResult GetView1()
{
    Employee emp = new Employee();
    emp.FirstName = "Sukesh";
    emp.LastName="Marla";
    emp.Salary = 20000;

    EmployeeViewModel vmEmp = new EmployeeViewModel();
    vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
    vmEmp.Salary = emp.Salary.ToString("C");
    if(emp.Salary>15000)
    {
        vmEmp.SalaryColor="yellow";
    }
    else
    {
        vmEmp.SalaryColor = "green";
    }

    vmEmp.UserName = "Admin";

    return View("MyView", vmEmp);
}
    }
}
