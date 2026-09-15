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
                return;
            }

            Console.Write("Введите цель тренеровки (1-жирожигание,2-кардиотренеровка,3-повышение выносливости): ");
            string target = Console.ReadLine();
            maxPuls = 220 - age;
            Console.WriteLine("Максимальный пульс: " + maxPuls);
            //TargetHearRate(maxPuls, target);
        }


        public static void TargetHearRate(int maxPuls, string target)
        {
            double recommendPulsMin;
            double recommendPulsMax;
            if (target == "1")
            {
                recommendPulsMin = Math.Ceiling(maxPuls * 0.6);
                recommendPulsMax = Math.Floor(maxPuls * 0.7);
                Console.WriteLine("Рекомендуемый пульс: " + recommendPulsMin + "-" + recommendPulsMax + "уд/мин");
            }
            else if (target == "2")
            {
                recommendPulsMin = Math.Ceiling(maxPuls * 0.7);
                recommendPulsMax = Math.Floor(maxPuls * 0.8);
                Console.WriteLine("Рекомендуемый пульс: " + recommendPulsMin + "-" + recommendPulsMax + "уд/мин");
            }
            else if (target == "3")
            {
                recommendPulsMin = Math.Ceiling(maxPuls * 0.8);
                recommendPulsMax = Math.Floor(maxPuls * 0.9);
                Console.WriteLine("Рекомендуемый пульс: " + recommendPulsMin + "-" + recommendPulsMax + "уд/мин");
            }
            else
            {
                Console.WriteLine("Вы ввели посторонний символ");
                InputData();

            }
        }


            static void Main(string[] args)
        {
            InputData();
            
        }
    }
}
