using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Velo : MuscularTransport
    {
        
        public Velo(Human force, int weight, int maxSpeed, string color, int price, string brandName, string model) : base(force, weight, maxSpeed, color, price, brandName, model) //doesn't allow create bike with a horse
        {
            Name = "Велосипед";
        }

        public override string Name { get; protected set; }
    }
}
