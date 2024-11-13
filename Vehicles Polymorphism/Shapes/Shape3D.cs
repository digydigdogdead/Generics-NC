using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape3D
    {
        public double GoldenRatio = 1.61803398874989484820458683436;
        public Shape BaseShape { get; set; }
        public abstract double CalculateVolume();
    }
}
