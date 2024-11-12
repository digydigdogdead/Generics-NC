using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal abstract class Vehicle
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
    }
}
