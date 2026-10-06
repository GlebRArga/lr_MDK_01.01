using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = CreateBike(1, "Велосипед", 1200, 12);
            Bike scooter = CreateBike(2, "Самокат", 700, 20);
            Bike rollers = CreateBike(3, "Ролики", 450, 15);
            Bike skis = CreateBike(4, "Лыжи", 1600, 8);
            Bike skateboard = CreateBike(5, "Скейтборд", 950, 10);
            List<Bike> allBike = new List<Bike>() { bike, scooter, rollers, skis, skateboard };
            Print(allBike);
            List<Bike> order = GetBike(allBike);
            FinalPrice(allBike, order);
            PrintRemains(allBike);

        }
        static Bike CreateBike(int id, string name, int price, int amount)
        {
            Bike Dish = new Bike() { id_ = id, name_ = name, price_ = price, amount_ = amount };
            return Dish;
        }
        static void Print(List<Bike> menus)
        {
            Console.Write("Парк проката: ");
            foreach (Bike menu in menus)
                Console.WriteLine($"{menu.id_}. {menu.name_} - {menu.price_} руб., {menu.amount_} шт.");
        }
        static List<Bike> GetBike(List<Bike> allBike)
        {
            List<Bike> Order = new List<Bike>();
           
            while (true)
            {
                Console.Write("Введите номер транспорта (0 — конец заказа):");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num > 5)
                    {
                        Console.WriteLine("Ошибка введите еще раз");
                    }
                    else
                    {
                        if (num == 0) break;
                        Console.Write("Введите количество:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        

                        foreach (Bike bike in allBike)
                            if (bike.id_ == num)
                            {
                                Bike ordered = CreateBike(bike.id_, bike.name_, bike.price_, b);
                                Order.Add(ordered);
                            }
                           
                    }
                }

            }
            return Order;
        }

        static void FinalPrice(List<Bike> allBike, List<Bike> order)
        {
            foreach (Bike bike in allBike)
            {
                int need = 0;
                foreach (Bike o in order)
                    if (o.id_ == bike.id_)
                        need += o.amount_;

                if (need > bike.amount_)
                {
                    Console.WriteLine($"Заказ не может быть принят, не хватает: {bike.name_}");
                    return;
                }
            }

            int total = 0;
            for (int i = 0; i < allBike.Count; i++)
            {
                Bike bike = allBike[i];
                for (int j = 0; j < order.Count; j++)
                {
                    if (order[j].id_ == allBike[i].id_)
                    {
                        bike.amount_ -= order[j].amount_;
                        total += bike.price_ * order[j].amount_;
                    }
                }
                allBike[i] = bike;
            }

            Console.WriteLine($"Стоимость заказа: {total} руб.");
        }

        static void PrintRemains(List<Bike> allBike)
        {
            Console.Write("Осталось транспорта: ");
            for (int i = 0; i < allBike.Count; i++)
            {
                Console.Write($"{allBike[i].name_} {allBike[i].amount_}");
                if (i < allBike.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }


    }
}
