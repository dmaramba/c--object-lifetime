using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NumberList
    {
        //Lazy<T> - T is the type/data tye I want to load
        // List<int> is my T
        Lazy<List<int>> list = new Lazy<List<int>>(() =>
        {
            Console.WriteLine("Loading numbers");
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            return numbers;
        });

        public List<int> GetList()
        {
            return list.Value;
        }

    }
}
