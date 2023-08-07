using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class SudentGrade : StudentMarks
    {
        public SudentGrade(string collegeName, string collegeAddress,int rno, string name, string address, int m1, int m2, int m3) : base(collegeName,collegeAddress,rno, name, address, m1, m2, m3)
        {
        }

        public char CalculateGrade()
        {
            double avg = CalculateAverage();
            if (avg >90)
            {
                return 'O';
            }
            else if (avg <= 90 && avg > 80)
            {
                return 'A';
            }
            else if (avg <= 80 && avg > 70)
            {
                return 'B';
            }
            else if (avg <= 70 && avg > 60) {
                return 'C';
            }
            else if (avg <= 60 && avg > 50)
            {
                return 'D';
            }
            else
            {
                return 'U';
            }
        }
    }
}
