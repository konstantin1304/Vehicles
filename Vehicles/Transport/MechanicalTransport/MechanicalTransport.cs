using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class MechanicalTransport : Transport
    {
        public MechanicalTransport(string brandName, string model, int weight, int maxSpeed, string color, int price) : base(weight, maxSpeed, color, price,brandName,model)
        {
            Name = brandName + model; 
        }

        public override string Name { get; protected set; }

        public override void Move()
        {
            Console.WriteLine($"{Name} {BrandName} {Model} поехал");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name} {BrandName} {Model} остановился");
        }
    }
}
