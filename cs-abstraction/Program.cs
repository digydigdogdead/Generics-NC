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
            //Console.WriteLine("The 'cs-abstraction' project is now running!");

            Scanner bobScanner = new Scanner("Home office scanner");
            Laptop bobLaptop = new Laptop("Work laptop"); 
            bobLaptop.ConnectScanner(bobScanner);

            App appThatExists = App.GetApp("render");
            App appThatDoesntExist = App.GetApp("recipes");

            //Console.WriteLine(appThatExists.Name);

            appThatExists.SetDevice(bobScanner);

            //Console.WriteLine(appThatExists.Device.Name);

            bobLaptop.InstalledApps.Add(appThatExists);
            appThatExists.SetDevice(bobLaptop);
            appThatExists.Run(bobLaptop);
            appThatExists.Run(bobScanner); 


        }
    }
}
