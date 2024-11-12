using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Engine
    {
        public bool Running { get; set; }
        public int HorsePower { get; set; }
        public FuelType FuelType { get; set; }

        public Engine()
        {
            HorsePower = 10;
            FuelType = FuelType.Diesel;
        }

        public void Start()
        {
            Running = true;
        }
    }
}
