using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes._3D_Shapes
{
    internal class RegularDodecahedron : Shape3D, IRollable
    {
        public double CalculateSurfaceArea()
        {
            RegularPentagon pentagon = (RegularPentagon)BaseShape;
            return ((15 * GoldenRatio) / (Math.Sqrt(3 - GoldenRatio))) * Math.Pow(pentagon.SideLength, 2);
        }

        public int Roll()
        {
            Random random = new Random();
            return random.Next(0, 12) + 1;
        }

        public override double CalculateVolume()
        {
            RegularPentagon pentagon = (RegularPentagon)BaseShape;
            return ((5 * Math.Pow(GoldenRatio, 3)) / (6 - (2 * GoldenRatio)) * Math.Pow(pentagon.SideLength, 3)); 
        }

        public RegularDodecahedron(RegularPentagon pentagon)
        {
            this.BaseShape = pentagon;
        }


    }
}
