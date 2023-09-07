using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Lab2_Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving_Account account = new Saving_Account();
            account.Interest(80000,10.5);
            Console.ReadLine();
        }
        class BankAccount 
        {
            public BankAccount()
            {
                int Account_number = 8989565;
                double Balance = 85000.95;
            } 
        }
        sealed class Saving_Account : BankAccount
        {
           
            public void Interest(double Balance,double rate)
            {
                Console.WriteLine("Your Interest: "+(rate * Balance)); 
            }
        }
    }
}
