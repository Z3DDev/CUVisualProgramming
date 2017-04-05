using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4Jagod
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] v = new Vehicle[9]; //Create the Vehicle Array List

            string option = "Y";
            int counter = 0; //Set position of 0 for the Array
            int remaining = 10; //Amount of Array spots remaining

            Console.WriteLine("Welcome to Inheritance Motors, the shops that covers most, if not all vehicles.");

            while (option == "Y") //Continues to run until user input signifies otherwise
            {
                Console.WriteLine("We can build you {0} vehicles, what would you like? Choose from the list below: ", remaining);

                List<string> list = new List<string>(new string[] { " -Boat", " -Bike", " -Car", " -Electric Car", " -Monster Truck", " ", "Type 'quit' to leave the shop" });
                //List of objects the user can have built

                foreach (string type in list)
                {
                    Console.WriteLine(type); //Prints out the list of buildable objects
                }

                string usrChoice = Console.ReadLine(); 
                usrChoice.ToLower();

                /*
                 * Based on User Input, there are a total of 5 Vehicle Options, and 1 Alternative Option (to quit the program)
                 * Each if/else-if statement includes the class specific strings/ints, and are called upon when taking in user input
                 * At the end of each user choice, a new Vehicle is compiled and put into the Vehicle Array through Counter
                 * These are stored until the user decides to quit the program, or they run out of array spots
                 */

                if (usrChoice == "boat")
                {
                    Console.WriteLine("What color is this Boat?");
                    string color = Console.ReadLine();

                    Console.WriteLine("What is the name of this Boat?");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is the top speed of this Boat?");
                    int topSpeed = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("How many motors are on this Boat?");
                    int numMotors = Int32.Parse(Console.ReadLine());

                    Boat bt = new Boat(color, name, topSpeed, numMotors); //Takes user input and creates the new vehicle

                    v[counter] = bt; //Adds newly created vehicle to Counter
                    counter++; //Adds +1 to the Counter for the next object to be created
                    remaining--; //Adds -1 to the Remaining counter
                }

                else if (usrChoice == "bike")
                {
                    Console.WriteLine("What color is this Bike?");
                    string color = Console.ReadLine();

                    Console.WriteLine("What is the name of this Bike?");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is the top speed of this Bike?");
                    int topSpeed = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("How many wheels are on this Bike?");
                    int numWheels = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("How many seats are on this Bike?");
                    int numSeats = Int32.Parse(Console.ReadLine());

                    Bike bk = new Bike(color, name, topSpeed, numWheels, numSeats);

                    v[counter] = bk;
                    counter++;
                    remaining--;
                }

                else if (usrChoice == "car")
                {
                    Console.WriteLine("What color is this Car?");
                    string color = Console.ReadLine();

                    Console.WriteLine("What is the name of this Car?");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is the top speed of this Car?");
                    int topSpeed = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("How many wheels are on this Car?");
                    int numWheels = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("How many doors are on this Car?");
                    int numDoors = Int32.Parse(Console.ReadLine());

                    Car c = new Car(color, name, numWheels, topSpeed, numDoors);

                    v[counter] = c;
                    counter++;
                    remaining--;
                }

                else if (usrChoice == "electric car")
                {
                    Console.WriteLine("What color is this Electric Car?");
                    string color = Console.ReadLine();

                    Console.WriteLine("What is the name of this Electric Car?");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is the top speed of this Electric Car?");
                    int topSpeed = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("How many wheels are on this Electric Car?");
                    int numWheels = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("How many seats are on this Electric Car?");
                    int numDoors = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("What is the kilowatts per hour for this Electric Car?");
                    int kwh = Int32.Parse(Console.ReadLine());

                    ElectricCar e = new ElectricCar(color, name, numDoors, numWheels, topSpeed, kwh);

                    v[counter] = e;
                    counter++;
                    remaining--;
                }

                else if (usrChoice == "monster truck")
                {
                    Console.WriteLine("What color is this Monster Truck?");
                    string color = Console.ReadLine();

                    Console.WriteLine("What is the name of this Monster Truck?");
                    string name = Console.ReadLine();

                    Console.WriteLine("What is the top speed of this Monster Truck?");
                    int topSpeed = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("How many wheels are on this Monster Truck?");
                    int numWheels = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("How many seats are on this Monster Truck?");
                    int numDoors = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("What is the size of the wheels (in feet) on this Monster Truck?");
                    int wheelSize = Int32.Parse(Console.ReadLine());

                    MonsterTruck m = new MonsterTruck(color, name, numDoors, numWheels, topSpeed, wheelSize);

                    v[counter] = m;
                    counter++;
                    remaining--;
                }

                else if (usrChoice == "N") //If User Input = N then the program will start to end, OR if remaining = 0
                {
                    foreach (Vehicle var in v) //For each spot in the Array list, the program will print out the results of the created vehicles
                    {
                        Console.WriteLine(var);
                    }

                    Console.WriteLine("Thank You For Visiting"); //So long random user
                    Console.ReadKey(); //Allows the user to read the results and goodbye message without program exiting by self
                    break; //ends the program
                }

                else
                {
                    Console.WriteLine("Please Enter a Valid Response"); //Reminds the User to enter something valid
                    Console.ReadKey();
                    continue; //If any key is accidentally pressed while options selected it will re-loop
                }
            }
        }
    }
}
