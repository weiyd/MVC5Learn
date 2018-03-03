using LearnMVC5.DataAccessLayer;
using LearnMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnMVC5.BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        //public List<Employee> GetEmployees()
        //{
        //    List<Employee> employees = new List<Employee>();
        //    Employee emp = new Employee();
        //    emp.FirstName = "johnson";
        //    emp.LastName = " fernandes";
        //    emp.Salary = 14000;
        //    employees.Add(emp);

        //    emp = new Employee();
        //    emp.FirstName = "michael";
        //    emp.LastName = "jackson";
        //    emp.Salary = 16000;
        //    employees.Add(emp);

        //    emp = new Employee();
        //    emp.FirstName = "robert";
        //    emp.LastName = " pattinson";
        //    emp.Salary = 20000;
        //    employees.Add(emp);

        //    return employees;
        //}
        // 获得数据库Employee数据
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            // 将全部Employee转为List
            return salesDal.Employees.ToList();
        }
    }
}