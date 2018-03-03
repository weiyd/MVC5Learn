using LearnMVC5.BusinessLayer;
using LearnMVC5.Models;
using LearnMVC5.ViewModels;
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
            return View("MyView2",emp);
        }
        public ActionResult GetViewModel()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            EmployeeBusinessLayer employeeBal = new EmployeeBusinessLayer();

            List<Employee> employees = employeeBal.GetEmployees();

            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + "|" + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;

            employeeListViewModel.UserName = "Admin";

            return View("MyView4", employeeListViewModel);
        }
    }
}