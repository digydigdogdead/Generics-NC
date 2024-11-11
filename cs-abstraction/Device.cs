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

        public virtual void InstallApp(App app)
        {
            this.InstalledApps.Add(app);
            app.SetDevice(this);
            if (app.Device == this)
            {
                Console.WriteLine("Installation successful");
            }
            else { Console.WriteLine("Installation unsuccessful"); }
        }

        public void RunDevice()
        {
            foreach (IRunnable app in InstalledApps)
            {
                app.Run(this);
            }
        }

    }
}
