using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeCSharp
{
    sealed class SecuritySystem
    {
        public void AuthenticateUser()
        {
            Console.WriteLine("Authenticatioon successful");
        }
    }
    //class child: SecuritySystem        //produces error as inheritance is not allowed in sealed class.
    //{
    //    public void AuthenticateUser()
    //    {
    //        Console.WriteLine("Authenticatioon successful");
    //    }
    //}
}
