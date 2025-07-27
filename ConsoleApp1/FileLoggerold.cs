using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FileLoggerold : IDisposable
    {
        private StreamWriter _writer;

        public FileLoggerold(string filePath)
        {
            _writer = new StreamWriter(filePath);
        }

        public void Log(string message)
        {
            _writer.WriteLine(message);
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose changes");
            _writer?.Dispose(); 
        }
    }
}




public class MyClass : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Resource cleaned up.");
    }
}