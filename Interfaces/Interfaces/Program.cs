using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle(); 
            double a = 10;
            double b = 20;
            double c = 1.0;
            double area = 0.0;
            double perimeter = 0.0;
            rec.height = a;
            rec.width = b;
            area = rec.Area();
            Console.WriteLine($"Rectange Area and Perimeter with height and width of {a}, {b}");
            Console.WriteLine($"Area of rectangle is: {area:F} ");
            perimeter = rec.perimeter();
            Console.WriteLine($"Perimeter of rectangle is: {perimeter:F} ");
            Console.WriteLine("");
            Console.WriteLine($"Circle Area and Perimeter with radius of {c}");
            circle.radius = c;
            area = circle.Area();
            Console.WriteLine($"Area of circle is: {area:F} ");
            perimeter = circle.perimeter();
            Console.WriteLine($"Perimeter of circle is: {perimeter:F} ");
            Console.WriteLine("");
            Console.WriteLine($"Triangle Area and Perimeter with sides 4, 5, 6");
            triangle.sideOne = 4;
            triangle.sideTwo = 5;
            triangle.sideThree = 6;
            area = triangle.Area();
            Console.WriteLine($"Area of triangle is: {area:F} ");
            perimeter = triangle.perimeter();
            Console.WriteLine($"Perimeter of triangle is: {perimeter:F} ");
            Console.ReadLine();
        }
    }
}
