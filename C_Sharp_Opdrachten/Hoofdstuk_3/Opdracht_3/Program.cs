using System;

namespace Opdracht_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool launchReady = false;
            int fuelLevel = 27000;

            if (fuelLevel >= 20000)
            {
                Console.WriteLine("Fuel level cleared.");
                launchReady = true;
            }
            else
            {
                Console.WriteLine("WARNING: Insufficient fuel!");
                launchReady = false;
            }

            if (launchReady)
            {
                Console.WriteLine("10, 9, 8...");
                Console.WriteLine("Fed parrot...");
                Console.WriteLine("6, 5, 4...");
                Console.WriteLine("Ignition...");
                Console.WriteLine("3, 2, 1...");
                Console.WriteLine("Liftoff!");
            }
            else
            {
                Console.WriteLine("Launch scrubbed.");
            }
        }
    }
}