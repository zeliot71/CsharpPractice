using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public Person(int age, string name, string gender)
        {
            Age = age;
            Name = name;
            Gender = gender;
        }
    }
}
