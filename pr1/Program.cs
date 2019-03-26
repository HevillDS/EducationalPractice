using System;

namespace pract
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Х: ");
            double x;
            if (double.TryParse(Console.ReadLine(), out x))
            {
             Console.WriteLine("Ввеfghgfghfдите Х: ");   
                double d = (-Math.Exp((-Math.Cos(Math.Sqrt(x + 5/3)))) - 1.7*Math.Atan( x/5 - 3/4 ) * Math.Sin(1.7 * x));
                Console.WriteLine(d);
            }
            else
            Console.WriteLine("Введено неверное число!");
            Console.ReadKey();
        }
    }
}
