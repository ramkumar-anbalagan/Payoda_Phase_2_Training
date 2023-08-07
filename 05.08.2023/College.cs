using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class College
    {
        private string? collegeName, collegeAddress;

        public College(string? collegeName, string? collegeAddress)
        {
            CollegeName = collegeName;
            CollegeAddress = collegeAddress;
        }

        public string? CollegeName { get => collegeName; set => collegeName = value; }
        public string? CollegeAddress { get => collegeAddress; set => collegeAddress = value; }

        public void DisplayCollege() {
            Console.WriteLine("College Name : " + CollegeName + "\nCollege Address : " + CollegeAddress+"\n\n");
        }
    }
}
