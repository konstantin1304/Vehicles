using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class TrainCargoDisel : Train, ICargo, ILiquidSystem
    {
        public double MaxCarryingCapacity { get ; set ; }
        public double EngineVolume { get ; set ; }
        public double Consumpton { get ; set ; }
        public double TankVolume { get ; set ; }

        public void TankUp(double fuelLiters)
        {
            throw new NotImplementedException();
        }
    }
}
