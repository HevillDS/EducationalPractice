using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mypr2
{
    class Program
    {
        public static Bike GetBike1()
        {
            Bike Bike1 = new Bike();
            Bike1.Purpose = "Enduro, AM";
            Bike1.Price = 40000;
            Bike1.Owner = "Hevill";
            Bike1.Frame = new Frame
            {
               Company = "Dartmoor",
               Model = "Hornet",
               Year = 2013
            };
            Bike1.Fork = new Fork
            {
                Company = "RockShox",
                Model = "Totem",
                Stroke = 180
            };
            Bike1.Wheels = new Wheels
            {
                Tires = "Schwalbe Magic Mary",
                Hubs = "Funn Fantom",
                Diameter = 26.0,
                Rims = "SunRingle Inferno 29",
                Spokes = "DTswiss",
                NumberOfSpokes = 32
            };
            return Bike1;
        }

        public static Bike GetBike2()
        {
            Bike Bike2 = new Bike();
            Bike2.Purpose = "AM";
            Bike2.Price = 50000;
            Bike2.Owner = "Leha";
            Bike2.Frame = new Frame
            {
               Company = "Commencal",
               Model = "Meta HT",
               Year = 2019
            };
            Bike2.Fork = new Fork
            {
                Company = "Fox",
                Model = "36",
                Stroke = 160
            };
            Bike2.Wheels = new Wheels
            {
                Tires = "Maxxis Minion",
                Hubs = "Formula",
                Diameter = 29.0,
                Rims = "WTB STP i25",
                Spokes = "DTswiss",
                NumberOfSpokes = 32
            };
            return Bike2;
        }

        public static Bike GetBike3()
        {
            Bike Bike3 = new Bike();
            Bike3.Purpose = "AM, Trail";
            Bike3.Price = 75000;
            Bike3.Owner = "AaronGwin";
            Bike3.Frame = new Frame
            {
               Company = "Dartmoor",
               Model = "Primal",
               Year = 2017
            };
            Bike3.Fork = new Fork
            {
                Company = "RockShox",
                Model = "Pike",
                Stroke = 140
            };
            Bike3.Wheels = new Wheels
            {
                Tires = "Schwalbe Nobby Nic",
                Hubs = "Hope Evo Pro",
                Diameter = 27.5,
                Rims = "DTswiss",
                Spokes = "DTswiss",
                NumberOfSpokes = 32
            };
            return Bike3;
        }

        static void Main(string[] args)
        {
            Bike Bike1 = GetBike1();
            Bike Bike2 = GetBike2();
            Bike Bike3 = GetBike3();

            List<Bike> bikes = new List<Bike>
            {
                Bike1,
                Bike2,
                Bike3
                
            };

            WriteBikesInfo(bikes);
            Console.WriteLine("Выберите номер сортировки:\n1)По диаметру колес;\n" +
                "2)По году рамы;\n" + "3)По ходу вилки\r\n");
            int s = Convert.ToInt32(Console.ReadLine());
            bool isOkInput = true;
            if (s == 1)
            {
                bikes.Sort(new WheelsDiameterComparer());
                Console.WriteLine("После сортировки по диаметру колес:");
            }
            else if (s == 2)
            {
                bikes.Sort(new FrameYearComparer());
                Console.WriteLine("После сортировки по году выпуска рамы рамы");
            }
            else if (s == 3)
            {
                bikes.Sort(new ForkStrokeComparer());
                Console.WriteLine("После сортировки по ходу вилки:");
            }
            else
            {
                isOkInput = false;
                Console.WriteLine("Неверный метод сортировки");
            }
            if (isOkInput)
            {
                WriteBikesInfo(bikes);
            }   

            Console.ReadKey();
        }

        public static void WriteBikesInfo(List<Bike> bikes)
        {
            Console.WriteLine("Список байков:\r\n");
            int n = 1;
            foreach(var Bike in bikes)
            {
                Console.WriteLine($"Байк {n}:\r\n");
                n++;
                string BikeInfo = $"Назначение: {Bike.Purpose}\r\n" +
                    $"Цена: {Bike.Price}\r\n" +
                    $"Владелец: {Bike.Owner}\r\n" +
                    $"Рама\r\n" +
                    $"Производитель: {Bike.Frame.Company}\r\n" +
                    $"Модель: {Bike.Frame.Model}\r\n" +
                    $"Год производства: {Bike.Frame.Year}\r\n" +
                    $"Вилка\r\n" +
                    $"Производитель: {Bike.Fork.Company}\r\n" +
                    $"Модель: {Bike.Fork.Model}\r\n" +
                    $"Ход: {Bike.Fork.Stroke}\r\n" +
                    $"Колеса\r\n" +
                    $"Покрышки: {Bike.Wheels.Tires}\r\n" +
                    $"Втулки: {Bike.Wheels.Hubs}\r\n" +
                    $"Диаметр: {Bike.Wheels.Diameter}\r\n" +
                    $"Обода: {Bike.Wheels.Rims}\r\n" +
                    $"Спицы: {Bike.Wheels.Spokes}\r\n" +
                    $"Кол-во спиц: {Bike.Wheels.NumberOfSpokes}\r\n";

                    Console.WriteLine(BikeInfo);
            }
        }
    }
}
