using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Transport : ITransport
    {
        public int Weight { get; set; }
        public int MaxSpeed { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
