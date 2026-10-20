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
        static void PrintPark(BikePark park)
        {
            Console.WriteLine("Парк проката:");
            List<TransportItem> items = park.GetPark();
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].GetName()} — {items[i].GetPrice()} руб., {items[i].GetAmount()} шт.");
            }
        }
        static bool IsNumber(string text)
        {
            if (text.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] < '0' || text[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
