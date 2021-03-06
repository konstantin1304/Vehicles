﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class TrainPassDisel : Train, IPassenger, ILiquidSystem
    {
        public TrainPassDisel(int passengersNumber, double engineVolume, double consumpton, double tankVolume, string brandName, string model, int weight, int maxSpeed, string color, int price) : base(brandName, model, weight, maxSpeed, color, price)
        {
            PassengersNumber = passengersNumber;
            EngineVolume = engineVolume;
            Consumpton = consumpton;
            TankVolume = tankVolume;
        }

        public int PassengersNumber { get ;  protected set; }
        public double EngineVolume { get ;  protected set; }
        public double Consumpton { get ;  protected set; }
        public double TankVolume { get ;  protected set; }

        public void TankUp(double fuelLiters)
        {
            Console.WriteLine($"Заправляем {fuelLiters} литров топлива в пассажирский поезд {Name}");
        }
    }
}
