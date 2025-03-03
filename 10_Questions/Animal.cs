using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeCSharp
{
    abstract class Animal
    {
        public virtual void MakeSound()
        {

        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog Barks!!!");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!!!");
        }
    }
}
