using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
            Area = 2 * Math.PI * Radius * Radius;
            Perimeter = 2 * Math.PI * Radius;
        }

        public double Radius;
    }
}
