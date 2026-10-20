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
        static List<OrderItem> GetOrder()
        {
            List<OrderItem> order = new List<OrderItem>();

            while (true)
            {
                Console.Write("Введите номер транспорта (0 — конец заказа): ");
                string inputId = Console.ReadLine();

                if (IsNumber(inputId) == false)
                {
                    Console.WriteLine("Ошибка: введите целое положительное число.");
                    continue;
                }

                int id = Convert.ToInt32(inputId);

                if (id == 0)
                {
                    break;
                }

                if (id < 1 || id > 5)
                {
                    Console.WriteLine("Ошибка: номер транспорта от 1 до 5.");
                    continue;
                }

                Console.Write("Введите количество: ");
                string inputQty = Console.ReadLine();

                if (IsNumber(inputQty) == false)
                {
                    Console.WriteLine("Ошибка: введите целое положительное число.");
                    continue;
                }

                int qty = Convert.ToInt32(inputQty);

                if (qty <= 0)
                {
                    Console.WriteLine("Ошибка: количество должно быть больше нуля.");
                    continue;
                }

                TransportType type = (TransportType)(id - 1);

                bool found = false;
                for (int i = 0; i < order.Count; i++)
                {
                    if (order[i].GetType() == type)
                    {
                        int newQty = order[i].GetQuantity() + qty;
                        order[i] = new OrderItem(type, newQty);
                        found = true;
                        break;
                    }
                }

                if (found == false)
                {
                    order.Add(new OrderItem(type, qty));
                }
            }
            return order;
        }
        static void ProcessOrder(BikePark park, List<OrderItem> order)
        {


            if (order.Count == 0)
            {
                Console.WriteLine("Заказ пуст.");
                return;
            }

            for (int i = 0; i < order.Count; i++)
            {
                TransportItem parkItem = park.FindTransport(order[i].GetType());
                if (parkItem.GetAmount() < order[i].GetQuantity())
                {
                    Console.WriteLine($"Заказ не может быть принят, не хватает: {parkItem.GetName()}");
                    return;
                }
            }

            int totalCost = 0;
            List<TransportItem> parkItems = park.GetPark();

            for (int i = 0; i < order.Count; i++)
            {
                for (int j = 0; j < parkItems.Count; j++)
                {
                    if (parkItems[j].GetTranspType() == order[i].GetType())
                    {
                        int newAmount = parkItems[j].GetAmount() - order[i].GetQuantity();

                        parkItems[j] = new TransportItem(
                            parkItems[j].GetTranspType(),
                            parkItems[j].GetName(),
                            parkItems[j].GetPrice(),
                            newAmount
                        );

                        totalCost += parkItems[j].GetPrice() * order[i].GetQuantity();
                        break;
                    }
                }
            }

            Console.WriteLine($"Стоимость заказа: {totalCost} руб.");
        }
        static void PrintRemains(BikePark park)
        {
            Console.Write("Осталось транспорта: ");
            List<TransportItem> items = park.GetPark();
            for (int i = 0; i < items.Count; i++)
            {
                Console.Write($"{items[i].GetName()} {items[i].GetAmount()}");
                if (i < items.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
