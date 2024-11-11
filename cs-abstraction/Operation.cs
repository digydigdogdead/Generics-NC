using cs_abs_enc_sprint.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_abstraction
{
    internal class Operation : IRunnable
    {
        public string Name { get; set; }

        private string operation { get; }

        public bool RequiresConnection { get; set; }

        public Operation(string name, string op, bool requiresConnection)
        {
            this.Name = name;
            this.operation = op;
            this.RequiresConnection = requiresConnection;
        }

        public void Run(Device device)
        {
             if ((this.RequiresConnection && device.IsConnected) || (!this.RequiresConnection))
                {
                Console.WriteLine(operation); 
                }
              else
                {
                    Console.WriteLine($"Your {device.Name} requires connection and is not connected");
                }

        }


    }
}
