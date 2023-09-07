using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Lab2_Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.display();
            Console.ReadLine();
        }
        public class Employee
        {
            int age;
            string name;
            double salary;
            public void display()
            {
                name = "Gopal Soni";
                age = 22;
                salary = 45000;
                Console.WriteLine("Name of Employee: " + name + "\n Age of Employee: " + age + "\n Salary of Employee: " + salary);
            }
        }
    }
}
