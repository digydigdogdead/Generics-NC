using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        private double BaseLength { get; set; }

        private double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return (BaseLength * Height) / 2;
        }
    }
}
