using System;
using ns;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Console_Lab2_Exercise_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Gopal";
            person.LastName = "soni";
            person.PrintFullName();
        }
        public partial class Person

        {
            public void PrintFullName()
            {
                Console.WriteLine($"{FirstName}{LastName}");
            }
        }

    }
}
