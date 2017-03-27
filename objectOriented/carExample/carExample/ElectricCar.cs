using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carExample
{
    class ElectricCar : Car
    {
        int kwh;

        public ElectricCar(int kwh, string color, string name, int numDoors, int numWheels, int topSpeed):base(color, name, numDoors, numWheels, topSpeed)
        {
            this.kwh = kwh;
        }

        public override string ToString()
        {
            return base.ToString() + " and the kwh is " + kwh;
        }
    }
}
