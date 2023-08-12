using EFDBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBF
{
    internal class CRUD
    {
        public void AddNewDept()
        {
            using (var context = new EmployeeMgmtContext())
            {
                var dept= new Dept()
                { 
                  Deptno = 10,  
                  Dname = "HR"
                };
                context.Depts.Add(dept);
                context.SaveChanges();
            }
        }

        public void UpdateeDept() {
            var context =new EmployeeMgmtContext();
            var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 10);
            seldept.Dname = "DEV";
            context.SaveChanges();

        }

        public void DeleteDept()
        {
            var context = new EmployeeMgmtContext();
            var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 10);
            
            context.SaveChanges();
        }

        public void InsertRecords()
        {
            using (var context = new EmployeeManagement())
            {


                var emp = new Emp()
                {
                    Empno = 2,
                    Empname = "Ram",
                    Deptno = 4
                };
                context.Emps.Add(emp);
                context.SaveChanges();


            }
        }
        public void UpdateRecords()
        {
            var context = new EmployeeManagement();
            var selectedEmp = context.Emps.FirstOrDefault(d => d.Deptno == 4);
            selectedEmp.Empname = "Ramkumar";
            context.SaveChanges();
        }
        public void DeleteRecord()
        {
            var context = new EmployeeManagement();

            var selectedEmp = context.Depts.FirstOrDefault(d => d.Deptno == 4);
            context.Depts.Remove(selectedEmp);
            context.SaveChanges();
        }
    }
}
