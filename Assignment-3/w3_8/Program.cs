using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_8
{
    public class MyClass
    {
        private void MyPrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }

        public void MyPublicMethod()
        {
            Console.WriteLine("This is a public method.");
            MyPrivateMethod(); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObj = new MyClass();
            myObj.MyPublicMethod();
            Console.ReadLine();
        }
    }

    ]
}
