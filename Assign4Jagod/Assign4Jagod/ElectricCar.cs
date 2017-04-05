using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4Jagod
{
    class ElectricCar : Car
    {
        int kwh;

        public ElectricCar(string color, string name, int topSpeed, int numWheels, int numDoors, int kwh) : base(color, name, numDoors, numWheels, topSpeed)
        {
            this.kwh = kwh;
        }

        public override string ToString()
        {
            return base.ToString() + " and the kwh is " + kwh;
        }
    }
}
