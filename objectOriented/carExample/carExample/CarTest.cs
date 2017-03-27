using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carExample
{
    class CarTest
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Car c1 = new Car("purple", "yo", 36, 1, 300);
            Car c2 = new Car("pink", "six", 5, 5, 5);

            c.printString();
            c1.printString();
            c2.printString();

            ElectricCar e = new ElectricCar(50, "pink", "ten", 40, 30, 20);
            Console.WriteLine("Electric" + Environment.NewLine + e);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(Car.count);
            Car.sharedCount();
            Console.ReadKey();
        }
    }
}
