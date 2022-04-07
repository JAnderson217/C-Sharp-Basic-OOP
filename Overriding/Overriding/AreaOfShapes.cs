using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class AreaOfShapes:AreaOfSquare
    {
        public double Rectangle(double a, double b)
        {
            return a * b;
        }
        //Override square method in AreaOfSquare
        public override double Square(double a, double b)
        {
            //return area of square with a*b, was a^b previously
            Console.WriteLine("Area of shapes called square a*b");
            return a*b;
        }

    }
}
