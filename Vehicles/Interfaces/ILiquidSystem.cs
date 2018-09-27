using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface ILiquidSystem
    {
        double EngineVolume{ get;}
        double Consumpton{ get;}
        double TankVolume { get;}

        void TankUp(double fuelLiters);
    }
}
