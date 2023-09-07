using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Lab2_Exercise_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog { name = "Jack", age = 2 };
            Cat cat = new Cat { name = "canel", age = 1 };
            Console.WriteLine("Dog name is: "+dog.display_name());
            Console.WriteLine("Dog age is: " + dog.display_age());
            Console.WriteLine("Cat name is: " + cat.display_name());
            Console.WriteLine("Cat age is: " + cat.display_age());
            Console.ReadKey();
        }
        abstract class Animal
        {
            public abstract string display_name();
            public abstract int display_age();
        }
        class Dog : Animal
        {
            public string name
            {
                get; set;
            }
            public int age
            {
                get; set;
            }
            public override string display_name()
            {
                return name; 
            }
            public override int display_age()
            {
                return age;
            }
        }
        class Cat : Animal
        {
            public string name
            {
                get; set;
            }
            public int age
            {
                get; set;
            }
            public override string display_name()
            {
                return name;
            }
            public override int display_age()
            {
                return age;
            }
        }
    }
}
