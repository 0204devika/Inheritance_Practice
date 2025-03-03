using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeCSharp
{
    public class Vehicle
    {
        public string? Brand { get; set; }
        public int speed { get; set; }
        public void DisplayInfo()
        {

        }
    }
    class Car : Vehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Car Brand: " + Brand + " Car Speed: " + speed);
        }
    }
    class Bike : Vehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Bike Brand: " + Brand + "Bike Speed: " + speed);
        }
    }
}
