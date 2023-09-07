using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk3_2
{
    public class Class2
    {
        public void AccessPrivateFieldFromClass1()
        {
            Class1 cs = new Class1();
            cs.Accesing();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.AccessPrivateFieldFromClass1 ();
        }
    }
}
