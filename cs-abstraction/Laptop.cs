using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_abstraction
{
    internal class Laptop : Device, IWirelessConnectable
    {
        public Laptop(string name) : base(name)
        {

        }

        public void ConnectScanner(Scanner scanner)
        {
            scanner.IsConnected = true;
            Console.WriteLine($"Your scanner {scanner.Name} is connected to {this.Name}");
        }

        public void Connect()
        {
            this.IsConnected = true;
            Console.WriteLine($"{this.Name} is connected to the internet"); 
        } 

    }
}
