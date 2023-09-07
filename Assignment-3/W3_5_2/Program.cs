using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3_5;

namespace W3_5_1
{
        public class MyDerivedClass : MyBaseClass
        {
            public void AccessProtectedInternalValue()
            {
                Console.WriteLine($"Accessing Protected Internal Value from AssemblyB: {protectedInternalValue}");
            }
        }
   
}
