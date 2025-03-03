using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeCSharp
{
    
    public class Machine 
    {
        public virtual void Start()
        {
            Console.WriteLine("Machine is starting");
        }
    }
    interface IMovable
    {
        void Move();
    }
    public class Robot : Machine,IMovable
    {
      public void Move()
        {
            Console.WriteLine("Robot is moving");
        }
      public override void Start()
        {
            Console.WriteLine("Robot is starting");
        }
    }
}
