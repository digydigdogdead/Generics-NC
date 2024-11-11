using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_abstraction
{
    internal class Scanner : Device 
    {
        public Scanner(string name) : base(name)
        {

        }

        public override void InstallApp(App app)
        {
            Console.WriteLine($"Cannot install applications on {this.Name}");

        }

    }
}
