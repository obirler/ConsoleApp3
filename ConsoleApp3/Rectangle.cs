using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Rectangle : Shape, IArea, IPerimeter
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
            Center = new System.Drawing.PointF(0, 0);
        }

        public double Height;

        public double Width;

        public double GetArea()
        {
            return Height * Width;
        }

        public double GetPerimeter()
        {
            return 2 *(Height + Width);
        }
    }
}
