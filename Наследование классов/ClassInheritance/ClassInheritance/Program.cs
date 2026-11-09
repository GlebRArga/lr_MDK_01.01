using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Product p1 = new Product();
            p1.SetName("Товар");
            p1.SetPrice(100.0);
            p1.SetSold(15);
            products.Add(p1);

            //Канцелярия
            Chancelery c0 = new Chancelery();
            c0.SetName("Ручка (0%)");
            c0.SetPrice(50.0);
            c0.SetSold(15);
            products.Add(c0);

            Chancelery с10 = new Chancelery();
            с10.SetName("Тетрадь (10%)");
            с10.SetPrice(120.0);
            с10.SetSold(50);
            products.Add(с10);

            Chancelery с30 = new Chancelery();
            с30.SetName("Бумага (30%)");
            с30.SetPrice(400.0);
            с30.SetSold(160);
            products.Add(с30);

            Chancelery с50 = new Chancelery();
            с50.SetName("Папка (50%)");
            с50.SetPrice(200.0);
            с50.SetSold(305);
            products.Add(с50);

            //Химия
            Chemistry ch0 = new Chemistry();
            ch0.SetName("Стиральный порошок (0%)");
            ch0.SetPrice(600.0);
            ch0.SetSold(4);
            products.Add(c0);

            Chemistry ch15 = new Chemistry();
            ch15.SetName("Мыло (15%)");
            ch15.SetPrice(80.0);
            ch15.SetSold(7);
            products.Add(ch15);

            Chemistry ch25 = new Chemistry();
            ch25.SetName("Шампунь (25%)");
            ch25.SetPrice(350.0);
            ch25.SetSold(12);
            products.Add(ch25);
        }
    }
}
