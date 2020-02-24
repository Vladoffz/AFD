using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS
{
    public sealed class Destination
    {
        public readonly string streetName;
        public readonly int Distance;

        public Destination(string streetName, int Distance)
        {
            this.streetName = streetName;
            this.Distance = Distance;
        }
    }
}
