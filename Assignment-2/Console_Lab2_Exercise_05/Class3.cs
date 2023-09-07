using System;

public class Class1
{
    partial class Person
    {
        string first_name = "Gopal";
        string last_name = "Soni";
        print_full_name()
        {
            Console.WriteLine("Your name is: "+first_name+" "+last_name);
            Console.ReadLine();
        }
    }
}
