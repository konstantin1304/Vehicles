using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Velo : MuscularTransport
    {
        public Velo(Human force) : base(force) //doesn't allow create bike with a horse
        {

        }
    }
}
