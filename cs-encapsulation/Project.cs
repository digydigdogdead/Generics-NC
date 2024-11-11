using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_encapsulation
{
    internal class Project
    {
        public string Name { get; private set; }
        //private string CompletionDate { get; set; }

        public Project(string name) {  Name = name; }

    }
}
