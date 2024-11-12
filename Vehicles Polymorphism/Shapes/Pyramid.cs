using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Pyramid : Shape3D
    {
        private double Height { get; set; }

        public Pyramid(Triangle triangle, double height)
        {
            BaseShape = triangle;
            Height = height;
        }

        public override double CalculateVolume()
        {
            double baseArea = BaseShape.CalculateArea();
            return (baseArea * Height) / 3;
        }
    }
}
