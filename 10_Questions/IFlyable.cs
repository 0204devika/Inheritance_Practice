using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeCSharp
{
    interface IFlyable
    {
        public void Fly()
        {
            
        }
    }
    interface ISwimmable
    {
        public void Swim()
        {
         
        }
    }
    class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Duck can fly");
        }
        public void Swim()
        {
            Console.WriteLine("Duck can swim");
        }   
    }
}
