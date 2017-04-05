using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4Jagod
{
    class Vehicle : Program
    {
        int topSpeed;
        string color;
        string name;

        public Vehicle(string color, string name, int topSpeed)
        {
            this.color = color;
            this.name = name;
            this.topSpeed = topSpeed;
        }

        public void printString()
        {
            Console.WriteLine("The name is " + name + " the color is " + color + " the top speed is " + topSpeed + "mph ");
        }

        public override string ToString()
        {
            return "The name is " + name + " the color is " + color + " the top speed is " + topSpeed + "mph ";
        }
    }
}
