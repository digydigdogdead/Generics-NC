using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cylinder : Shape3D
    { 
        public double Height { get; set; }
    
        public Cylinder(Circle circle, double height)
        {
            BaseShape = circle;
            Height = height;

        }
        public override double CalculateVolume()
        {
            double baseArea = BaseShape.CalculateArea();
            return baseArea * Height;
        }
    }
}
