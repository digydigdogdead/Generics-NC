using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class PentagonalTrapezohedron : Shape3D, IRollable
    {
        Kite BaseShape { get; set; }
        public override double CalculateVolume()
        {
            // A Pentagonal Trapezohedron can be decompiled into 2 Pentagonal Pyramids and one Pentagonal Antiprism
            double pyramidArea = (5.0 + Math.Sqrt(5)) / 24.0 * Math.Pow(BaseShape.LongSide, 3);
            double antiprismArea;

            double theCosBit = Math.Cos(Math.PI / 10);
            double antiprismNumerator = 5.0 * Math.Sqrt(4 * Math.Pow(theCosBit, 2) - 1) * Math.Sin((3 * Math.PI) / (2 * 5));
            double antiprismDenominator = 12 * Math.Sin(Math.PI / 5) * Math.Sin(Math.PI / 5);

            antiprismArea = (antiprismNumerator / antiprismDenominator) * Math.Pow(BaseShape.ShortSide, 3);

            return (2 * pyramidArea) + antiprismArea;

        }

        public int Roll()
        {
            Random random = new Random();
            return random.Next(0, 10) + 1;
        }

        public PentagonalTrapezohedron(Kite kite)
        {
            this.BaseShape = kite;
        }
    }
}
