using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface ILiquidSystem
    {
        double EngineVolume{ get; set; }
        double Consumpton{ get; set; }
        double TankVolume { get; set; }

        void TankUp(double fuelLiters);
    }
}
