using System;

namespace Zadanie_2._2___Kalkulator_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w kalkulatorze BMI");

            Console.WriteLine("Podaj swoją wagę [w KG]");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj swój wzrost w M [np. 1,50]");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = a / (b*b);

            Console.WriteLine($"Twoje BMI wynosi {c:0.##}");
            
            if (c < 18.5)
            {
                Console.WriteLine("Masz niedowagę.");
            }
            else if (c >= 18.5 && c < 25)
            {
                Console.WriteLine("Twoja waga jest prawidłowa.");
            }
            else if (c >= 25 && c < 30)
            {
                Console.WriteLine("Masz nadwagę.");
            }
            else
            {
                Console.WriteLine("Masz otyłość -  jesteś chory");
            }
        }
    }
}