using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk3_6
{
    internal class Program
    {
        public class MyBaseClass
        {
            public int MyProperty { get; set; }
        }

    
        public class MyDerivedClass : MyBaseClass
        {
            public void AccessProperty()
            {
                MyProperty = 42;
                Console.WriteLine($"Value of MyProperty in MyDerivedClass: {MyProperty}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                MyDerivedClass derivedObj = new MyDerivedClass();

                derivedObj.AccessProperty();

                Console.ReadLine();
            }
        }

    }
}
