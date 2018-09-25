using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Transport.MechanicalTransport
{
    class TrainCargoElectro : Train, ICargo, IElectricSystem
    {
        public double Consumpton { get ; set ; }
        public double BatteryVolume { get ; set ; }
        public double MaxCarryingCapacity { get ; set ; }

        public void Charging(double mHa)
        {
            throw new NotImplementedException();
        }
    }
}
