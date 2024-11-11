using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_abstraction
{
    abstract class Device
    {
        public string Name { get; set; }

        public Boolean IsConnected { get; set; } 

        public List<IRunnable> InstalledApps { get; set; }

        public Device(string name)
        {
            this.Name = name;
            this.InstalledApps = new List<IRunnable>(); 
        }

    }
}
