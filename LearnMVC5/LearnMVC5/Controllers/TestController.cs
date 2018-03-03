using LearnMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnMVC5.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }
    } 
    public class TestController : Controller
    {
        // GET: Test
        [NonAction]
        public string GetString()
        {
            return "控制器直接返回的字符串";
        }
        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "weiyd";
            c.Address = "Milink";
            return c;
        }
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;
            ViewData["Employee"] = emp;
            return View("MyView");
        }
    }
}