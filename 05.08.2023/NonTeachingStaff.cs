using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class NonTeachingStaff : StaffDetails
    {
        private double basicSalary;
        private readonly int _da, _hra, _cca, _pf;

        public NonTeachingStaff(string collegeName, string collegeAddress, int eno, string? name, string? address, double basicSalary, int da, int hra, int cca, int pf) : base(collegeName, collegeAddress, eno, name, address)
        {
            BasicSalary = basicSalary;
            _da = da;
            _hra = hra;
            _cca = cca;
            _pf = pf;
        }

        public double BasicSalary { get => basicSalary; set => basicSalary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

        public float CalculateSalary()
        {
            float netSal = (float)(BasicSalary + ((BasicSalary * ((float)Da / 100)) + (BasicSalary * ((float)Hra / 100)) + (BasicSalary * ((float)Cca / 100)) - (BasicSalary * ((float)Pf / 100))));
            return netSal;
        }

        public void Display()
        {
            Console.WriteLine("Staff Name : " + Name + "\nBasic Salary : " + BasicSalary+"\n");
        }
    }
}
