using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Sphere : Shape3D
    {
        public Sphere(Circle baseShape)
        {
            BaseShape = baseShape;    
        }

        public override double CalculateVolume()
        {
            Circle baseCircle = (Circle)BaseShape;
            return (Math.PI * Math.Pow(baseCircle.Radius, 3)) * ((double)4 / (double)3);
        }
    }
}
