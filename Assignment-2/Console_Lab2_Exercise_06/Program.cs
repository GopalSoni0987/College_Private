using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Lab2_Exercise_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.salary();
            Console.ReadLine();

        }
        partial class Employee
        {
            string employee_name = "Gopal Soni";
            string emmployee_address = "Gandhi chawk mathura";
            int employee_age = 22;
            string employee_profile = "Full Stack Developer";
        }
        partial class Employee
        {
            public void salary()
            {
                Console.WriteLine("Salary based on emp job profile and experience:");
                Console.WriteLine(employee_name + " salary is: 45000");
            }
        }
    }
}
