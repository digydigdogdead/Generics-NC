using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class CarEngine : Engine
    {
        public CarEngine()
        {
            Horsepower = 30;
            FuelType = FuelType.UNLEADED;
        }
    }
}
