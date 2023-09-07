using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using wk3_3_2;
    public class ExternalClass
    {
        public void AccessInternalField()
        {
            MyClass myObject = new MyClass();
            int value = myObject.internalField;
            Console.WriteLine($"Accessed internalField: {value}");
        }
    }
    
