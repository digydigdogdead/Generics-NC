using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Prism : Shape3D
    {
        private double Height { get; set; }
        public Prism(Triangle triangle, double height)
        {
            BaseShape = triangle;
            Height = height;
        }

        public Prism(Shape shape, double height)
        {
            BaseShape = shape;
            Height = height;
        }

        public override double CalculateVolume()
        {
            double baseArea = BaseShape.CalculateArea();
            return baseArea * Height;
        }
    }
}
