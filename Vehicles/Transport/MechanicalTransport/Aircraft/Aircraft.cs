﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Aircraft : MechanicalTransport
    {
        public Aircraft(string brandName, string model, int weight, int maxSpeed, string color, int price) : base(brandName, model, weight, maxSpeed, color, price)
        {

        }
    }
}
