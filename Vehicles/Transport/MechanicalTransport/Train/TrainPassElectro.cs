using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class TrainPassElectro : Train, IPassenger, IElectricSystem
    {
        public int PassengersNumber { get ; set ; }
        public double Consumpton { get ; set ; }
        public double BatteryVolume { get ; set ; }

        public void Charging(double mHa)
        {
            throw new NotImplementedException();
        }
    }
}
