using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class Student
    {
        public string Name { get;}
        public List<int> Grades { get;}
        
        public Student(string name) 
        { 
            Name = name;
            Grades = new List<int>();
        }

        public void addGrade (int grade)
        {
            Grades.Add(grade);   
        }
        public double CalculateAvarageGrade()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }
            int sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }
            return (double)sum / Grades.Count;
        }
    }
}
