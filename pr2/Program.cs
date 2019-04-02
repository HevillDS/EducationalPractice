using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    public class Program
    {
        public static Bike GetDartmoorHornet()
        {
            Bike DartmoorHornet = new Bike();
            DartmoorHornet.Purpose = "Enduro, AM";
            DartmoorHornet.Price = 40000;
            DartmoorHornet.Owner = "Hevill";
            DartmoorHornet.Frame = new Frame
            {
               Company = "Dartmoor",
               Model = "Hornet",
               Year = "2013"
            };
            DartmoorHornet.Fork = new Fork
            {
                Company = "RockShox",
                Model = "Totem",
                Stroke = 180
            };
            DartmoorHornet.Wheels = new Wheels
            {
                Tires = "Schwalbe Magic Mary",
                Hubs = "Funn Fantom",
                Diameter = 26,
                Rims = "SunRingle Inferno 29",
                Spokes = "DTswiss",
                NumberOfSpokes = 32
            };
            return DartmoorHornet;
        }

        public static Bike GetCommencal()
        {
            Bike Commencal = new Bike();
            Commencal.Purpose = "AM";
            Commencal.Price = 50000;
            Commencal.Owner = "Leha";
            Commencal.Frame = new Frame
            {
               Company = "Commencal",
               Model = "Meta HT",
               Year = "2017"
            };
            Commencal.Fork = new Fork
            {
                Company = "Fox",
                Model = "36",
                Stroke = 180
            };
            Commencal.Wheels = new Wheels
            {
                Tires = "Maxxis Minion",
                Hubs = "Formula",
                Diameter = 26,
                Rims = "WTB STP i25",
                Spokes = "DTswiss",
                NumberOfSpokes = 32
            };
            return Commencal;
        }

        public static Bike GetDartmoorPrimal()
        {
            Bike DartmoorPrimal = new Bike();
            DartmoorPrimal.Purpose = "AM, Trail";
            DartmoorPrimal.Price = 75000;
            DartmoorPrimal.Owner = "AaronGwin";
            DartmoorPrimal.Frame = new Frame
            {
               Company = "Dartmoor",
               Model = "Primal",
               Year = "2017"
            };
            DartmoorPrimal.Fork = new Fork
            {
                Company = "RockShox",
                Model = "Pike",
                Stroke = 140
            };
            DartmoorPrimal.Wheels = new Wheels
            {
                Tires = "Schwalbe Nobby Nic",
                Hubs = "Hope Evo Pro",
                Diameter = 27.5,
                Rims = "DTswiss",
                Spokes = "DTswiss",
                NumberOfSpokes = 32
            };
            return DartmoorPrimal;
        }

       
        public static void Main(string[] args)
        {
            Bike DartmoorHornet = GetDartmoorHornet();
            Bike Commencal = GetCommencal();
            Bike DartmoorPrimal = GetDartmoorPrimal();

            List<Bike> Bikes = new List<Bike>
            {
                DartmoorHornet,
                Commencal,
                DartmoorPrimal
                
            };
            WriteBikesInfo(Bikes);
            Console.WriteLine("Выберите номер сортировки:\n1)По диаметру колес;\n" +
                "2)По ходу вилки\r\n");
            int s = Convert.ToInt32(Console.ReadLine());
            bool isOkInput = true;
            if (s == 1)
            {
                SortByDiameter(Bikes, true);
                Console.WriteLine("После сортировки по диаметру колес:");
            }
            else if (s == 2)
            {
                Bikes.Sort();
                Console.WriteLine("После сортировки по ходу вилки:");
            }
            else
            {
                isOkInput = false;
                Console.WriteLine("Неверный метод сортировки");
            }
            if (isOkInput)
            {
                WriteBikesInfo(Bikes);
            }   

            Console.ReadKey();
        }

         /// <summary>
        ///  Сортировка по диаметру колес
        /// </summary>
        /// <param name="Bikes">список байков</param>
        /// <param name="isAscending">сортировка по возрастанию</param>
        public static void SortByDiameter(List<Bike> Bikes, bool isAscending)
        {
            for (int i = 0; i < Bikes.Count(); i++)
            {
                for (int j = 0; j < Bikes[i].Wheels.Diameter - i - 1; j++)
                {
                    if (isAscending)
                    {
                        if (Bikes[j].Wheels.Diameter > Bikes[j + 1].Wheels.Diameter)
                        {
                            Bike temp = Bikes[j];
                            Bikes[j] = Bikes[j + 1];
                            Bikes[j + 1] = temp;
                        }
                    }
                    else
                    {
                        if (Bikes[j].Wheels.Diameter > Bikes[j + 1].Wheels.Diameter)
                        {
                            Bike temp = Bikes[j];
                            Bikes[j] = Bikes[j + 1];
                            Bikes[j + 1] = temp;
                        }
                    }
                }
            }
        }

        public static void WriteBikesInfo(List<Bike> Bikes)
        {
            Console.WriteLine("Список байков:\r\n");
            int n = 1;
            foreach(var Bike in Bikes)
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
                }
                 int i = 1;
                foreach(var diameter in Bike.Wheels.Diameter)
                {
                    BikeInfo += $"Колеса {i}\r\n" +
                        $"Тип: {pickup.Type}\r\n" +
                        $"Цвет: {pickup.Color}\r\n";
                    i++;
                }
                i = 1;
                foreach (var guitarString in Bike.Fork)
                {
                    BikeInfo += $"Вилка {i}\r\n" +
                        $"Компания: {guitarString.Metal}\r\n" +
                        $"Толщина: {guitarString.Gauge}\r\n";
                    i++;
                }
                Console.WriteLine(BikeInfo);
            }

        }
    }
