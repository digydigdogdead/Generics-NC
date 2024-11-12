using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class MotorcycleEngine : Engine
    {
        public MotorcycleEngine()
        {
            Horsepower = 20;
            FuelType = FuelType.LEADED;
        }
    }
}
