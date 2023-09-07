using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Lab2_Exercise_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.LogMessage();
            Console.ReadLine();
        }
        public static class Logger
        {
            public static void LogMessage()
            {
                Console.WriteLine("This is static method");
            }
        }
    }
}
