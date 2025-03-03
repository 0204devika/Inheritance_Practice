using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeCSharp
{
    class Account
    {
        public int amount { get; set; }
        public int rateofinterest { get; set; }
        public int years { get; set; }
        public virtual void CalculateInterest()
        {
            int res = (amount * rateofinterest * years) / 100;
            Console.WriteLine("Interest: " + res);
        }
    }
    sealed class SavingsAccount : Account
    {
        public override void CalculateInterest()
        {
            base.CalculateInterest();
        }
    }
}
