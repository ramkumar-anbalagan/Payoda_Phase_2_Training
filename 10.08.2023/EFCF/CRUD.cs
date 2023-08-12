using EFCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCF.Models.context;
using Microsoft.EntityFrameworkCore;


namespace EFDBF
{
    internal class CRUD
    {
        //   public void AddNewDept()
        // {
        //   using (var context = new EmployeeManagementContext())
        // {
        //   var dept = new Dept()
        // {
        //   Deptno = 10,
        // DName = "HR"
        //};
        //context.Depts.Add(dept);
        //context.SaveChanges();
        //}
        //}

        //public void UpdateeDept()
        //{
        //  var context = new EmployeeManagementContext();
        //var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 10);
        //seldept.DName = "DEV";
        //context.SaveChanges();

        //}

        //public void DeleteDept()
        //{
        // var context = new EmployeeManagementContext();
        // var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 10);

        //  context.SaveChanges();
        //}
        public void InsertRecords()
        {
            using (var context = new EmployeeManagement())
            {


                var emp = new Emp()
                {
                    Empno = 101,
                    Empname = "Ram",
                    Deptno = 2
                };
                context.Emps.Add(emp);
                context.SaveChanges();


            }
        }
        public void UpdateRecords()
        {
            var context = new EmployeeManagement();
            var selectedEmp = context.Emps.FirstOrDefault(d => d.Deptno == 2);
            selectedEmp.Empname = "Kumar";
            context.SaveChanges();
        }
        public void DeleteRecord()
        {
            var context = new EmployeeManagement();

            var sEmp = context.Depts.FirstOrDefault(d => d.Deptno == 2);
            context.Depts.Remove(sEmp);
            context.SaveChanges();
        }



    }
}
