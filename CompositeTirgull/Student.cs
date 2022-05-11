using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTirgull
{
    internal class Student : IAvTipus
    {
        private double grade;

        public Student()
        {
            Random ran = new Random();
            grade = ran.Next(0, 100);
        }
        public double GetGrade()
        {
            return grade;        }
    }
}
