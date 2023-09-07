using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_7
{

    public class MyClass
    {
        private int myPrivateProperty;

        public MyClass(int initialValue)
        {
            myPrivateProperty = initialValue;
        }

        public void ModifyPrivateProperty(int newValue)
        {
            myPrivateProperty = newValue;
        }
        public int GetPrivatePropertyValue()
        {
            return myPrivateProperty;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObj = new MyClass(10);

            int initialValue = myObj.GetPrivatePropertyValue();
            Console.WriteLine($"Initial Value: {initialValue}");

            myObj.ModifyPrivateProperty(20);

            int updatedValue = myObj.GetPrivatePropertyValue();
            Console.WriteLine($"Updated Value: {updatedValue}");

            Console.ReadLine();
        }
    }

}
