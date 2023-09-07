using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Lab2_Exercise_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathHelper.Calculateaverage();
            Console.ReadLine();
        }
        public static class MathHelper
        {
            public static void Calculateaverage()
            {
                int[] arr = { 4, 5, 6, 7, 78 };
                int sum = 0;
                double average;
                for(int i=0;i<arr.Length; i++)
                {
                    sum += arr[i];
                }
                average = sum /(arr.Length);
                Console.WriteLine("Average: "+average);
            }
        }
    }
}
