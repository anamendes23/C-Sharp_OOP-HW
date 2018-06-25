using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Student
    {
        public string _name;
        public string _id;
        public List<double> grades = new List<double>();

        public Student(string name, string id)
        {
            _name = name;
            _id = id;
        }

        public double[] Grades { get => grades.ToArray(); }
        public int GradeListSize { get => grades.Count; }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ReplaceGrade(int index, double newGrade)
        {
            grades[index] = newGrade;
        }

        public double GetAverageGrade()
        {
            double sum = 0;

            foreach (double g in grades)
            {
                sum += g;
            }
            return sum / grades.Count();
        }
    }
}
