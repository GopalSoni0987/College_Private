using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk3_5
{
    public class MyBaseClass
    {
        protected internal int protectedInternalValue = 42;

        public void PrintProtectedInternalValue()
        {
            Console.WriteLine($"Protected Internal Value: {protectedInternalValue}");
        }
    }
}
