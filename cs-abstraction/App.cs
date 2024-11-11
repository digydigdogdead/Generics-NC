using cs_abs_enc_sprint.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_abstraction
{
    internal class App
    {
        public string Name { get; set; }
        private ApplicationFunctions Function { get; set; }
        public bool RequiresConnection { get; set; }
        public Device Device { get; set; }

        public App(string name, ApplicationFunctions function, bool requiresConnection)
        {
            Name = name;
            Function = function;
            RequiresConnection = requiresConnection;
        }
    }
}
