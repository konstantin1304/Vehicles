using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface IElectricSystem
    {
        double Consumpton { get;}
        double BatteryVolume { get;}

        void Charging(double mHa);
    }
}
