using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
            Area = Height * Width;
            Perimeter = 2 * (Height + Width);
        }

        public double Height;

        public double Width;
    }
}
