using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7.Classes
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student() { }

        public Student(int studentId, string firstName, string lastName, int age) 
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

    }
}
