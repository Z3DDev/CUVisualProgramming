using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4Jagod
{
    class Bike : WheeledVehicle
    {
        int numSeats;

        public Bike(string color, string name, int topSpeed, int numWheels, int numSeats) : base(color, name, topSpeed, numWheels)
        {
            this.numSeats = numSeats;
        }

        public override string ToString()
        {
            return base.ToString() + " and the number of seats is " + numSeats;
        }
    }
}
