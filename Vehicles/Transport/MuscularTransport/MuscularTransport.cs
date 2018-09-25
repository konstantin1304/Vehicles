using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
        public class MuscularTransport: Transport
        {
        public DrivingForce Force { get; protected set; }

        public MuscularTransport(DrivingForce force)
        {
            this.Force = force; 
        }

        }
}
