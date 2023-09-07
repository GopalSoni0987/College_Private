using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_9
{
    using System;
    public class MyBaseClass
    {
        protected void MyProtectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public void AccessProtectedMethod()
        {
            Console.WriteLine("Calling a protected method from the derived class:");
            MyProtectedMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedObj = new MyDerivedClass()
            derivedObj.AccessProtectedMethod();
            Console.ReadLine();
        }
    }

}
