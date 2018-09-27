using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Transport : ITransport
    {
        public int Weight { get;  protected set; }
        public int MaxSpeed { get;  protected set; }
        public string Color { get;  protected set; }
        public int Price { get;  protected set; }
        public string BrandName { get; protected set; }
        public string Model { get; protected set; }

        public abstract string Name { get; protected set; }

        public abstract void Move();
        public abstract void Stop();

        public Transport(int weight, int maxSpeed, string color, int price, string brandName, string model) 
        {
            BrandName = brandName;
            Model = model;
            Weight = weight;
            MaxSpeed = maxSpeed;
            Color = color;
            Price = price;
        }
    }
}
