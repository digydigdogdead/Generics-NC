using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_encapsulation
{
    internal class Customer
    {
        public string Name { get; private set; }
        private string Address { get; set; }
        public Customer(string name, string address = "New York") 
        {
            this.Name = name;
            this.Address = address;
        }
    }
}
