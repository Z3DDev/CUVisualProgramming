using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carExample
{
    class Car
    {
        public static int count;
        string color;
        string name;
        int numDoors;
        int numWheels;
        int topSpeed;

        public Car(string color, string name, int numDoors, int numWheels, int topSpeed)
        {
            count++;
            this.color = color;
            this.name = name;
            this.numDoors = numDoors;
            this.numWheels = numWheels;
            this.topSpeed = topSpeed;
        }

        public Car()
        {
            count++;
        }

        public void printString()
        {
            Console.WriteLine("Your car color is " + color + " the number of doors is " + numDoors + " the number of wheels is " + numWheels + " the top speed is " + topSpeed + " and it's name is " + name);
        }

        public override string ToString()
        {
            return "Your car color is " + color + " the number of doors is " + numDoors + " the number of wheels is " + numWheels + " the top speed is " + topSpeed + " and it's name is " + name;

        }

        public static void sharedCount()
        {
            Console.WriteLine("count " + count);
        }
    }
}
