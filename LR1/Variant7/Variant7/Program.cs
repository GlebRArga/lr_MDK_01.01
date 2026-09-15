using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Variant7
{
    internal class Program
    {
   
        public static void InputData()
        {

            int maxPuls = 0;
            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 0 ||  age > 120)
            {
                Console.WriteLine("Вы ввели неккоректный возраст");
                InputData();
            }

            Console.Write("Введите цель тренеровки (1-жирожигание,2-кардиотренеровка,3-повышение выносливости): ");
            string target = Console.ReadLine();
            maxPuls = 220 - age;
            Console.WriteLine("Максимальный пульс: " + maxPuls);
            //TargetHearRate(maxPuls, target);
        }

        
        


        static void Main(string[] args)
        {
            InputData();
            
        }
    }
}
