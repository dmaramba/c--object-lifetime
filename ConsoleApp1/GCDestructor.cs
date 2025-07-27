using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GCDestructor
    {

        public GCDestructor() {
            CreateStudent();

            GC.Collect();
            GC.WaitForPendingFinalizers();


            Console.WriteLine("GC is done");

        }
        static void CreateStudent()
        {
            var student = new Student("John Doe");
        }
    }

}
