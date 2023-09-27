using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10._5._1
{
    internal class Logger : ILogger
    {
        public void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void Event()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
