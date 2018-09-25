using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface IElectricSystem
    {
        double Consumpton { get; set; }
        double BatteryVolume { get; set; }

        void Charging(double mHa);
    }
}
