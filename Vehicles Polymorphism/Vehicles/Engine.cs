using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Engine
    {
        protected internal bool Running { get; set; }
        protected internal int HorsePower { get; set; }
        protected internal FuelType FuelType { get; set; }

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
