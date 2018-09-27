using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class AutoElectric : Automobile, IPassenger, IElectricSystem
    {
        public AutoElectric(int passengersNumber, double consumpton, double batteryVolume, string brandName, string model, int weight, int maxSpeed, string color, int price) : base(brandName, model, weight, maxSpeed, color, price)
        {
            PassengersNumber = passengersNumber;
            Consumpton = consumpton;
            BatteryVolume = batteryVolume;
        }

        public int PassengersNumber { get ;  protected set; }
        public double Consumpton { get ;  protected set; }
        public double BatteryVolume { get ;  protected set; }

        public void Charging(double mHa)
        {
            Console.WriteLine($"Поступление {mHa} электроэнергии в электромобиль {Name}");
        }
    }
}
