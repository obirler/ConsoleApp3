﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Rectangle : Shape, IArea, IPerimeter
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
            SomeOtherParameter = Width;
            Center = new System.Drawing.PointF(20, 10);
        }

        public double SomeOtherParameter;

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
