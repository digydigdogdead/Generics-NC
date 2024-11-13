using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class RegularOctagon : Shape
    {
        public double SideLength;
        public override double CalculateArea()
        {
            return (2 * (Math.Pow(SideLength, 2)) * (1 + Math.Sqrt(2)));
        }

        public RegularOctagon(double sideLength)
        {
            this.SideLength = sideLength;
        }
    }
}
