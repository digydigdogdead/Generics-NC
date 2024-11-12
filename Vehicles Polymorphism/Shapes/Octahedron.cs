using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Octahedron : Shape3D, IRollable
    {
        public Octahedron(Triangle baseShape)
        {
            this.BaseShape = baseShape;
        }

        public override double CalculateVolume()
        {
            Triangle castTriangle = (Triangle)BaseShape;
            return ((double)1 / (double)3) * Math.Pow(castTriangle.BaseLength, 2) * castTriangle.Height * 2;
        }

        public int Roll()
        {
            Random random = new Random();
            return random.Next(0, 8) + 1;
        }
    }
}
