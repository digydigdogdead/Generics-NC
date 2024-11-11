using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_abstraction
{
    internal class Smartphone : Device, IWirelessConnectable
    {
        public Smartphone(string name) : base(name)
        {

        }

        public void Connect()
        {
            this.IsConnected = true;
            Console.WriteLine($"{this.Name} is connected to the internet");
        }

    }
}
