using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class StaffDetails :College
    {
        int eno;
        private string? name, address;

        public StaffDetails(string collegeName,string collegeAddress,int eno, string? name, string? address):base(collegeName,collegeAddress)
        {
            this.eno = eno;
            this.name = name;
            this.address = address;
        }

        public int Eno { get => eno; set => eno = value; }
        public string? Address { get => address; set => address = value; }
        public string? Name { get => name; set => name = value; }
    }
}
