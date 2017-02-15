using System;

namespace Quiz1ConsoleBug
{
    class Program
    {
        static void Main(string[] args)
        {
            int switchNum = 5;
            switch (switchNum)
            {

                case 1:
                    Console.WriteLine("switchNum is 1");
                    break;
                case 2:
                    Console.WriteLine("switchNum is 2");
                    break;
                case 3:
                    Console.WriteLine("switchNum is 3");
                    break;
                case 4:
                    Console.WriteLine("switchNum is 4");
                    break;
                default:
                    Console.WriteLine("switchNum is 5");
                    break;

            }

            while (switchNum > 0)
            {
                Console.WriteLine("We are in the loop! The current value of switchNum is " + switchNum);
                switchNum--;
            }

            Console.ReadLine();
        }
    }
}
