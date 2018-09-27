using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class DrivingForce
    {
        public DrivingForce(double sleepEndurance, double feedEndurance, string name, string kindName)
        {
            SleepEndurance = sleepEndurance;
            FeedEndurance = feedEndurance;
            Name = name;
            KindName = kindName;
        }

        public double SleepEndurance { get; protected set; }
        public double FeedEndurance { get; protected set; }
        public string Name { get; protected set; }
        public string KindName { get; protected set; }

        public abstract void FeedUp(double foodKg);

        public abstract void SleepUp(double hours);
       
    }
}
