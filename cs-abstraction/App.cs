using cs_abs_enc_sprint.abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cs_abstraction
{
    internal class App : IRunnable 
    {
        public string Name { get; set; }
        private ApplicationFunctions Function { get; set; }
        public bool RequiresConnection { get; set; }
        public Device Device { get; set; }
        public static List<App> Apps { get; }

        public App(string name, ApplicationFunctions function, bool requiresConnection)
        {
            Name = name;
            Function = function;
            RequiresConnection = requiresConnection;
        }

        static App()
        {
            Apps = new List<App>
            {
                new App("WELCOME", ApplicationFunctions.WELCOME, false),
                new App("DATA", ApplicationFunctions.DATA, true),
                new App("BACKUP", ApplicationFunctions.BACKUP, true),
                new App("RENDER", ApplicationFunctions.RENDER, false)
            };
        }

        public static App? GetApp(string name) 
        {
            foreach (var app in Apps)
            {
                if (app.Name == name.ToUpper()) { return app; }
            }
            Console.WriteLine($"App {name} not found.");
            return null;
        }

        public void SetDevice(Device device)
        {
            this.Device = device;

        }
        
        // should bool connected be used?
        public void Run(Device device)
        {
            if (device.InstalledApps.Contains(this))
            {
                if ((this.RequiresConnection && device.IsConnected) || (!this.RequiresConnection)) 
                {
                    Console.WriteLine("Functionality is running");
                    Functionality.ExecuteFunction(this.Function);
                }
                else
                {
                    Console.WriteLine($"Your {device.Name} requires connection and is not connected");
                }
            }
            else
            {
                Console.WriteLine($"{device.Name} does not have this {this.Name} installed");
            }
            

        }

    }
}
