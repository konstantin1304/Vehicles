using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Horse : DrivingForce
    {
        public Horse(double sleepEndurance, double feedEndurance, string name) : base(sleepEndurance, feedEndurance, name, "лошадь")
        {

        }

        public override void FeedUp(double foodKg)
        {
            Console.WriteLine($"Кормим {KindName} {foodKg} килограммами овса");
        }

        public override void SleepUp(double hours)
        {
            Console.WriteLine($"{KindName} спит в течении {hours} часов");
        }
    }
}
