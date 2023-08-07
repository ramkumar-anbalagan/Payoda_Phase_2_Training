using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class TeachingStaff :StaffDetails
    {
        private string? dept;
        private double basicSalary;
        private readonly int _da, _hra, _cca, _pf;

        public TeachingStaff(string collegeName,string collegeAddress,int eno, string? name, string? address,string? dept, double basicSalary,int da,int hra,int cca,int pf) : base(collegeName, collegeAddress,eno,name,address)
        {
            this.dept = dept;
            this.basicSalary = basicSalary;
            _da = da;
            _hra = hra;
            _cca = cca;
            _pf = pf;
        }

        public string? Dept { get => dept; set => dept = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

        public float CalculateSalary() {
            float netSal = (float)(BasicSalary + ((BasicSalary * ((float)Da / 100)) + (BasicSalary * ((float)Hra / 100)) + (BasicSalary * ((float)Cca / 100)) - (BasicSalary * ((float)Pf / 100))));
            return netSal;
        }
        public void Display() {
            Console.WriteLine("Staff Name : " + Name+"\nStaff Department : "+Dept+"\nBasic Salary : "+BasicSalary+"\n");
        }
    }
}
