﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class AirPass : Aircraft, IPassenger, ILiquidSystem
    {
        public AirPass(string brandName, string model, int weight, int maxSpeed, string color, int price) : base(brandName, model, weight, maxSpeed, color, price)
        {
        }

        public int PassengersNumber { get ;  protected set; }
        public double EngineVolume { get ;  protected set; }
        public double Consumpton { get ;  protected set; }
        public double TankVolume { get ;  protected set; }

        public void TankUp(double fuelLiters)
        {
            Console.WriteLine($"Заправляем {fuelLiters} литров топлива в пассажирский самолёт {Name}");
        }
    }
}
