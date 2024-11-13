using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Kite : Shape
    {
        public double ShortSide { get; set; }
        public double LongSide { get; set; }
        public double InsideAngle { get; set; }
        public override double CalculateArea()
        {
            return ShortSide * LongSide * Math.Sin(InsideAngle);
        }

        public Kite(double shortSide, double longSide, double insideAngle)
        {
            this.ShortSide = shortSide;
            this.LongSide = longSide;
            this.InsideAngle = insideAngle;
        }
    }
}
