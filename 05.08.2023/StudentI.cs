using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class StudentI: College
    {
        private int rno;
        private string? name,address;

        public StudentI(string collegeName,string collegeAddress,int rno, string? name, string? address) : base(collegeName,collegeAddress)
        {
            Rno = rno;
            Name = name;
            Address = address;
        }

        public int Rno { get => rno; set => rno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }

        public void DisplayDetails(){
            Console.WriteLine("\nRoll No : " + Rno + "\nStudent Name : " + Name + "\nAddress : " + Address+"\n");
        }
    }
}
