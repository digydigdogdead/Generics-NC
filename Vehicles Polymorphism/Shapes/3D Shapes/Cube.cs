using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Cube : Shape3D, IRollable
    {
        public double SideLength;
        public Cube(Rectangle baseShape)
        {
            if (baseShape.Length != baseShape.Width)
            {
                throw new ArgumentException("Using a non-square rectangle to create cube");
            } else
            {
                BaseShape = baseShape;
                SideLength = baseShape.Width;
            }

           
        }
        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        public int Roll()
        {
            Random random = new Random();
            return random.Next(1, 6) + 1;
        }
    }
}
