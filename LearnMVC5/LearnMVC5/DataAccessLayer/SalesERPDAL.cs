using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LearnMVC5.Models;

namespace LearnMVC5.DataAccessLayer
{
    public class SalesERPDAL: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //片段「TblEmployee」代表的是表名。在运行时讲自动被创建
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
        //DbSet 将会展示所有可以在数据库中查询到的 Employees
        public DbSet<Employee> Employees { get; set; }
    }
}