using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4Jagod
{
    class Car : WheeledVehicle
    {
        int numDoors;

        public Car(string color, string name, int topSpeed, int numWheels, int numDoors) : base(color, name, numWheels, topSpeed)
        {
            this.numDoors = numDoors;
        }

        public override string ToString()
        {
            return base.ToString() + " and the number of doors is " + numDoors;
        }
    }
}
