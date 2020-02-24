using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS
{
    public enum TransportType
    {
        Foot,
        Car,
        Van,
        Ship,
        Bike,
        Plane
    };
    public sealed class Transport
    {
        public readonly int speed;
        public readonly int requiredWidth;
        public readonly int requiredHeight;
        public readonly int requiredWeight;
        public readonly TransportType type;
        public readonly bool isBusy;
        public Transport(int speed, int requiredWidth, int requiredHeight, int requiredWeight, TransportType type, bool isBusy)
        {
            this.speed = speed;
            this.requiredWidth = requiredWidth;
            this.requiredHeight = requiredHeight;
            this.requiredWeight = requiredWeight;
            this.type = type;
            this.isBusy = isBusy;
        }
    }
}
