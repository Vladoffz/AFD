using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS
{
    class Order
    {
        public readonly Good good;
        public readonly Transport transport;
        public readonly Destination destination;
        public readonly DateTimeOffset deliveryTime;

        public Order(Good good, Transport transport, Destination destination, DateTimeOffset deliveryTime)
        {
            this.good = good;
            this.destination = destination;
            if (transport.requiredHeight >= good.Height && transport.requiredWeight >= good.Weight &&
                transport.requiredWidth >= good.Width)
            {
                this.transport = transport;
            }
            else
            {
                throw new ArgumentException("Insert right transport!");
            }

            this.deliveryTime = deliveryTime;
        }

        public DateTimeOffset MakeOrder()
        {
            DateTimeOffset time = deliveryTime;
            time = time.AddMinutes(this.destination.Distance / this.transport.speed);
            Random rnd = new Random();

            if (deliveryTime > DateTime.Today.AddHours(7) && deliveryTime < DateTime.Today.AddHours(9))
                time = time.AddHours(rnd.Next(1, 2));

            if (this.transport.isBusy)
                time = time.AddHours(rnd.Next(1, 9));
            time = time.AddMinutes(destination.Distance * 10);
            return time;
        }
    }
}
