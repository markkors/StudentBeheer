using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBeheer.Models
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudentClass { get; set; }
        public string StudentNumber { get; set; }

        public Student(string name, int age, string studentclass, string studentnumber)
        {
            Name = name;
            Age = age;
            StudentClass = studentclass;
            StudentNumber = studentnumber;
        }

        public override string ToString()
        {
            return $"{Name} ({StudentNumber}), {StudentClass}";
        }
    }
}
