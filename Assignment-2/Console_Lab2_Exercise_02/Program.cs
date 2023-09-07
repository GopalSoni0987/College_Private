using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Lab2_Exercise_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.display();
            Console.ReadLine();
        }
        public class BankAccount
        {
            double account_number;
            string account_holdername;
            double account_balance = 50000;          
            double addmoney = 80000;
            double withdrawalmoney = 8000;
            public void deposit()
            {
                account_balance += addmoney;
            }
            public void withdrawal()
            {
                account_balance -= withdrawalmoney;
            }
            public void display()
            {
                Console.WriteLine("Add some money to your account: " + addmoney);
                Console.WriteLine("deducted some money to your account: " + withdrawalmoney);
                Console.WriteLine("Money after deposit: " + (account_balance + addmoney));
                Console.WriteLine("Money after withdrawal: " + (account_balance - withdrawalmoney));
            }
        }
    }
}
