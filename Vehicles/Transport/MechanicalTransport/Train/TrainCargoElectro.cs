using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class TrainCargoElectro : Train, ICargo, IElectricSystem
    {
        public TrainCargoElectro(double consumpton, double batteryVolume, double maxCarryingCapacity, string brandName, string model, int weight, int maxSpeed, string color, int price) : base(brandName, model, weight, maxSpeed, color, price)
        {
            Consumpton = consumpton;
            BatteryVolume = batteryVolume;
            MaxCarryingCapacity = maxCarryingCapacity;
        }

        public double Consumpton { get ;  protected set; }
        public double BatteryVolume { get ;  protected set; }
        public double MaxCarryingCapacity { get ;  protected set; }

        public void Charging(double mHa)
        {
            Console.WriteLine($"Поступление {mHa} электроэнергии в грузовом поезде {Name}");
        }
    }
}
