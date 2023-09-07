using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk3_1
{
    public class MyClass
    {
        private string PrivateField;

        public void setValue(string value)
        {
            PrivateField = value;
            Console.WriteLine(PrivateField);
            Console.ReadLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.setValue("Rohit Varshney");
            
        }
    }
}
