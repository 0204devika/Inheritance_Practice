namespace InheritancePracticeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car c = new Car();
            //c.Brand = "BMW";
            //c.speed = 50;
            //c.DisplayInfo();

            //Car1 car = new Car1 { Brand = "BMW", speed = 120, Carcolor = "White" };
            //Bike1 bike = new Bike1 { Brand = "Yamaha", speed = 80, Bikecolor = "Sport" };

            //car.DisplayInfo();
            //bike.DisplayInfo();

            //Animal d = new Dog();
            //d.MakeSound();
            //Animal c = new Cat();
            //c.MakeSound();

            //Account a = new SavingsAccount();
            //a.amount = 50000;
            //a.rateofinterest = 3;
            //a.years = 2;
            //a.CalculateInterest();

            //Duck d = new Duck();
            //d.Fly();
            //d.Swim();

            //Product p = new ElectronicProduct();
            //p.Name = "Laptop";
            //p.Price = 50000;
            //p.GetDiscountedPrice();

            //Manager m = new Manager("devika", 10000, 5000);
            //m.Display();

            //Student s = new Student { Name="devika",Age=21,RollNo=47};
            //s.Display();
            //Person p = s;


            ////p.S__Display();   //this is produce error(upcasting)

            //Student s1 =  (Student)p;
            //s1.S__Display();  

            Robot r = new Robot();
            r.Move();
            r.Start();





        }
    }
}
