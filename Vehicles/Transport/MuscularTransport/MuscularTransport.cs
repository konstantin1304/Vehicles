using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
        public abstract class MuscularTransport: Transport
        {

        protected MuscularTransport(DrivingForce force, int weight, int maxSpeed, string color, int price, string brandName, string model) : base(weight, maxSpeed, color, price, brandName, model)
        {
            Force = force;
            Weight = weight;
            MaxSpeed = maxSpeed;
            Color = color;
            Price = price;
        }

        public DrivingForce Force { get; protected set; }


        public override void Move()
        {
            Console.WriteLine($"{Name} {BrandName} {Model} c {Force.KindName} по имени {Force.Name} поехал");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name} {BrandName} {Model} c {Force.KindName} по имени {Force.Name} остановился");
        }
    }
}
