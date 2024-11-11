using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_abstraction
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Scanner bobScanner = new Scanner("bobScanner");
            Laptop bobLaptop = new Laptop("bobLaptop");
            Smartphone bobSmartphone = new Smartphone("bobSmartphone");

            List<Device> devices = new List<Device>
            {
                bobScanner,
                bobLaptop,
                bobSmartphone
            };

            devices.ForEach(device => device.RunDevice());

            foreach (Device item in devices)
            {
                item.InstallApp(App.GetApp("RENDER"));
                item.InstallApp(App.GetApp("WELCOME"));
                item.InstallApp(App.GetApp("BACKUP"));
                item.InstallApp(App.GetApp("DATA"));
            }

            bobLaptop.Connect(); 
            bobSmartphone.Connect();


            foreach (Device item in devices)
            {
                item.RunDevice();
            }


        }
        }
}
