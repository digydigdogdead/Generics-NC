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
           // this.InstalledApps.Add(new Operation("Scroll", $"{this.Name} is scrolling based on user input...", false));
        }

        public void Connect()
        {
            this.IsConnected = true;
            Console.WriteLine($"{this.Name} is connected to the internet");
        }

    }
}
