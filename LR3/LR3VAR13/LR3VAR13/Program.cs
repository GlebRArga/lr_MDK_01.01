using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3VAR13
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static BikePark CreatePark()
        {
            BikePark park = new BikePark();
            park.AddTransport(new TransportItem(TransportType.Bicycle, "велосипед", 1200, 12));
            park.AddTransport(new TransportItem(TransportType.Scooter, "самокат", 700, 20));
            park.AddTransport(new TransportItem(TransportType.Rollers, "ролики", 450, 15));
            park.AddTransport(new TransportItem(TransportType.Skis, "лыжи", 1600, 8));
            park.AddTransport(new TransportItem(TransportType.Skateboard, "скейтборд", 950, 10));
            return park;
        }

    }
}
