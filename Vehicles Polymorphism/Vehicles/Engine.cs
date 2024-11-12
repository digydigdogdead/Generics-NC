﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Engine
    {
        public bool Running { get; set; }
        public int Horsepower { get; set; }
        public FuelType FuelType { get; set; }

        public Engine()
        {
            Horsepower = 10;
            FuelType = FuelType.DIESEL;
        }

        public void Start()
        {
            Running = true;
        }
    }
}
