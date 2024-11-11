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
            Console.WriteLine("The 'cs-abstraction' project is now running!");

            Scanner bobScanner = new Scanner("Home office scanner");
            Laptop bobLaptop = new Laptop("Work laptop"); 
            bobLaptop.ConnectScanner(bobScanner);


        }
    }
}
