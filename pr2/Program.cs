using System;

namespace pr2
{
    class Band 
    {
        public string BandName; //название
        public string Genre;  //основной жанр
        public string Country //страна

        public List<Members> Members //участники, поля: лидер, основной состав, для переопределенных + временные участники
        public List<Instruments> Instruments //основные музыкальные инструменты


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
