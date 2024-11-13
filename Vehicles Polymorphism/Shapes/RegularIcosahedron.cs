using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class RegularIcosahedron : Shape3D, IRollable
    {
        public RegularIcosahedron(Triangle triangle)
        {
            double checker = triangle.BaseLength * Math.Sqrt(3) / 2;
            if (triangle.Height != Math.Round((triangle.BaseLength * Math.Sqrt(3) / 2), 2))
            { throw new ArgumentException("The baseshape of a Regular Icosahedron needs to be an equilateral triangle."); }
            this.BaseShape = triangle;
        }

        public override double CalculateVolume()
        {
            Triangle triangle = this.BaseShape as Triangle;
            return ((5.0 * (Math.Pow(GoldenRatio, 2)) / 6.0) * Math.Pow(triangle.BaseLength, 3));
        }

        public int Roll()
        {
            Random random = new Random();
            return random.Next(0, 20) + 1;
        }
    }
}
