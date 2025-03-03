using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeCSharp
{
    public class Vehicle1
    {
        public string Brand { get; set; }
        public int speed { get; set; }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Vehicle Brand: " + Brand + " Vehicle Speed: " + speed);
        }
    }
    class Car1 : Vehicle1
    {
        public string Carcolor { get; set; }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Car Color: " + Carcolor);
        }
    }
    class Bike1 : Vehicle1
    {
        public string Bikecolor { get; set; }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Bike Color: " + Bikecolor);
        }
    }
}
