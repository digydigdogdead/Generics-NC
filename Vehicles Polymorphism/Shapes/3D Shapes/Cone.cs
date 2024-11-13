using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cone : Shape3D
    {
        private double Height { get; set; }
        public Cone(Circle circle, double height)
        {
            BaseShape = circle;
            Height = height;

        }

        public override double CalculateVolume()
        {
            double baseArea = BaseShape.CalculateArea();
            return (baseArea * Height) / 3;
        }
    }
}
