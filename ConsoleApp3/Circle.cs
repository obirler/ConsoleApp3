using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Circle : Shape, IArea, IPerimeter
    {
        public Circle(double radius)
        {
            Radius = radius;
           
            Center = new System.Drawing.PointF(0, 0);
        }

        public double Radius;

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
