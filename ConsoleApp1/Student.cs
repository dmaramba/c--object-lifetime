using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
            Console.WriteLine($"Welcome {Name}");
        }
        ~Student()
        {
            Console.WriteLine($"Removed {Name}");
        }
    }
}
