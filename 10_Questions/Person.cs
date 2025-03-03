using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeCSharp
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public void Display()
        {
            Console.WriteLine("Name: " + Name + " Age: " + Age);
        }
    }
    class Student : Person
    {
        public int RollNo { get; set; }
        public void S__Display()
        {
            Console.WriteLine("Name: " + Name + " Age: " + Age + " Roll no : " + RollNo);
        }
    }

}
