using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FileLogger : IDisposable
    {
        private StreamWriter _writer;

        public FileLogger(string fileName)
        {
            _writer = new StreamWriter(fileName, true);
        }

        public void WriteLogText(string logText)
        {
            _writer.WriteLine($"{DateTime.Now.ToString("dd-mm-yy HH:mm")} - {logText}" );
        }

        public void Dispose()
        {
            Console.WriteLine("Closing the file log writer");
            _writer.Close();
            _writer.Dispose();
        }
    }
}
