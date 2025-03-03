using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeCSharp
{
    class Product
    {
        public string? Name { get; set; }
        public int Price { get; set; }
        public virtual void GetDiscountedPrice()
        {

        }
    }
    class ElectronicProduct : Product
    {
        public override void GetDiscountedPrice()
        {
            int discountedPrice = Price - (Price * 10) / 100;
            Console.WriteLine("Discounted Price for electronic products: " + discountedPrice);
        }
    }
    class ClothingProduct : Product
    {
        public override void GetDiscountedPrice()
        {
            int discountedPrice = Price - (Price * 50) / 100;
            Console.WriteLine("Discounted Price for clothing products: " + discountedPrice);
        }
    }
        
}

        
    

