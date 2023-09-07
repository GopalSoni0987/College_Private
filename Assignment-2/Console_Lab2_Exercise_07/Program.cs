using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Lab2_Exercise_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle { radius = 5 };
            Rectangle rectangle = new Rectangle { width =6,height=4};
            Console.WriteLine("Circle Area: " + circle.Calculate_Area());
            Console.WriteLine("Rectangle Area: "+ rectangle.Calculate_Area());
            Console.ReadKey();
        }
        abstract class Shape
        {
            public abstract double Calculate_Area();
        }
        class Circle : Shape
        {
            public double radius
            {
                get; set;
            }
            public override double Calculate_Area()
            {
                return Math.PI*radius*radius;
            }
        }
        class Rectangle : Shape
        {
            public double width 
            {
                get; set;
            }
            public double height
            {
                get; set;
            }
            public override double Calculate_Area()
            {
                return width * height;
            }
        }
    }
}
