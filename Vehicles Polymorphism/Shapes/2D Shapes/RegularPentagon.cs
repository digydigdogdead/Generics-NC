using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class RegularPentagon : Shape
    {
        public double SideLength;
        public override double CalculateArea()
        {
            return ((SideLength * SideLength) * Math.Sqrt(25 + (10 * Math.Sqrt(5)))) / 4.0;
        }

        public RegularPentagon(double sideLength)
        {
            this.SideLength = sideLength;
        }
    }
}
