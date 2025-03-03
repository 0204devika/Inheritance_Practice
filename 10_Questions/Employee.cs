using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeCSharp
{
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
    }
    class Manager : Employee
    {
        public int Bonus { get; set; }
        public Manager(string name, int salary, int bonus) : base(name, salary)
        {
            Bonus = bonus;
        }
        public void Display()
        {
            Console.WriteLine("Employee Name: " + Name + " Employee Salary: " + Salary + " Employee Bonus: " + Bonus);
        }
    }

}
