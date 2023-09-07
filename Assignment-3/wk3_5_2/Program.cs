using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wk3_5;
using wk3_5_2;

namespace wk3_5_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyDerivedClass derivedObj = new MyDerivedClass();

            derivedObj.PrintProtectedInternalValue();
            derivedObj.AccessProtectedInternalValue();

            Console.ReadLine();
        }
    }
}
