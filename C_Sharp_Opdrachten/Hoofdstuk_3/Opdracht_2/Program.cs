namespace Opdracht_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool launchReady = false;
            bool crewStatus = true;
            string computerStatus = "green";

            if (crewStatus && computerStatus == "green")
            {
                Console.WriteLine("Crew & computer cleared.");
                launchReady = true;
            }
            else
            {
                Console.WriteLine("WARNING: Crew or computer not ready!");
                launchReady = false;
            }

            if (launchReady)
            {
                Console.WriteLine("10, 9, 8, 7, 6, 5, 4, 3, 2, 1...");
                Console.WriteLine("Fed parrot...");
                Console.WriteLine("Ignition...");
                Console.WriteLine("Liftoff!");
            }
            else
            {
                Console.WriteLine("Launch scrubbed.");
            }
        }
    }
}