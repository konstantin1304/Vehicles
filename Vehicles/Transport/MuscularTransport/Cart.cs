using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Cart : MuscularTransport
    {
        public Cart(Horse force, int weight, int maxSpeed, string color, int price, string brandName, string model) : base(force, weight, maxSpeed, color, price, brandName, model)
        {
            Name = "Телега";
        }

        public override string Name { get; protected set; }
    }
}
