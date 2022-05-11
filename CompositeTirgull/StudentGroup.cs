using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTirgull
{
    internal class StudentGroup:IAvTipus
    {
        public List<Student> students = new List<Student>();

        public double GetGrade()
        {
            double sum = 0;
            foreach (Student student in students)
                sum+=student.GetGrade();
            return (sum/students.Count);
        }
    }
}
