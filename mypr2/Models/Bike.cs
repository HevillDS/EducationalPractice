using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mypr2
{
    public class Bike 
    {
        public string Purpose { get; set; } //назначение
        public int Price { get; set; } //цена
        public string Owner { get; set; } //владелец
        public Frame Frame { get; set; } //рама
        public Fork Fork { get; set; }  //вилка
        public Wheels Wheels { get; set; } //колеса
    }
    
    //    public class WheelsDiameterComparer : IComparer<Bike>
    //     {
    //         public int Compare(Bike bike1, Bike bike2)
    //         {
    //             if (bike1.Wheels.Diameter.Sort()[0] > bike2.Wheels.Diameter.Sort()[0])
    //                 return 1;
    //             else if (bike1.Wheels.Diameter.Sort()[0] < bike2.Wheels.Diameter.Sort()[0])
    //                 return -1;
    //             else
    //                 return 0;
    //         }
        
    //     }

        public class FrameModelComparer : IComparer<Bike>
        {
            public int Compare(Bike bike1, Bike bike2)
            {
                if (bike1.Frame.Model.ToLower()[0] > bike2.Frame.Model.ToLower()[0])
                    return 1;
                else if (bike1.Frame.Model.ToLower()[0] < bike2.Frame.Model.ToLower()[0])
                    return -1;
                else
                    return 0;
            }
        
        }

         public class ForkStrokeComparer : IComparer<Bike>
        {
            public int Compare(Bike bike1, Bike bike2)
            {
                if (bike1.Fork.Stroke.ToLower()[0] > bike2.Fork.Stroke.ToLower()[0])
                    return 1;
                else if (bike1.Fork.Stroke.ToLower()[0] < bike2.Fork.Stroke.ToLower()[0])
                    return -1;
                else
                    return 0;
            }
        
        }

}