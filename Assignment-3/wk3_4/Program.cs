using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk3_4
{
    public class MyBaseClass
    {
        protected int protectedField = 42;
        protected void ProtectedMethod()
        {
            Console.WriteLine("ProtectedMethod in MyBaseClass");
        }
    }
    public class MyDerivedClass : MyBaseClass
    {
        public void AccessProtectedMembers()
        {
            Console.WriteLine($"Accessing protectedField from MyDerivedClass: {protectedField}");
            ProtectedMethod();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedObj = new MyDerivedClass();

            derivedObj.AccessProtectedMembers();
        }
    }
}



