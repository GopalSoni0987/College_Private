using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk3_2
{
        internal class Class1
        {
            private string privateField = "This is a private field.";

            public void Accesing()
            {
                Console.WriteLine($"Accessing private field from Class1: {privateField}");
                Console.ReadLine();
            }
        }
}

