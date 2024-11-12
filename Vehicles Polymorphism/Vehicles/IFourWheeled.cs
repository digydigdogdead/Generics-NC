using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal interface IFourWheeled
    {
        bool IsFourWheelDrive { get; set; }

        void ChangeTyres(string tyreManufacturer);
    }


}
