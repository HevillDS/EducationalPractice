using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    public class Bike 
    {
        public string Purpose { get; set; } //назначение
        public int Price { get; set; } //цена
        public string Owner { get; set; } //владелец
        public Frame Frame { get; set; } //рама
        public Fork Fork { get; set; }  //вилка
        public Wheels Wheels { get; set; } //колеса
    

    /// <summary>
        /// Сравнение по назначению
        /// </summary>
        /// <param name="Bike"></param>
        /// <returns></returns>
        public int CompareTo(Bike Bike)
        {
            return this.Purpose.CompareTo(Bike.Purpose);
        }
    }
    public class FrameModelComparer : IComparer<Bike>
    {
        public int Compare(Bike Bike1, Bike Bike2)
        {
            if (Bike1.Frame.Model.ToLower()[0] > Bike2.Frame.Model.ToLower()[0])
                return 1;
            else if (Bike1.Frame.Model.ToLower()[0] < Bike2.Frame.Model.ToLower()[0])
                return -1;
            else
                return 0;
        }
    
    }
}
