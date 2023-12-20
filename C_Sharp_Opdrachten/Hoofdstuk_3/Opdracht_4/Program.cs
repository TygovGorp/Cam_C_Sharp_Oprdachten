namespace Opdracht_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Vul hier je antwoorden voor de vragen in!
             * b: false dus het klopt
             * c: true dus het klopt
             * d: launchReady wordt op false gezet omdat er niet genoeg fuel is en daarna true omdat de crew en computer status klaar zijn          * 
             */


            bool launchReady = false;
            int fuelLevel = 17000;
            bool crewStatus = true;
            string computerStatus = "green";

            if (fuelLevel >= 20000)
            {
                Console.WriteLine("Fuel level cleared.");
                launchReady = true;

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
            }
            else
            {
                Console.WriteLine("WARNING: Insufficient fuel!");
                launchReady = false;

            }



            if (launchReady)
            {
                Console.WriteLine("10, 9, 8, 7, 6, 5, 4, 3, 2, 1...");
                Console.WriteLine("Liftoff!");
            }
            else
            {
                Console.WriteLine("Launch scrubbed.");
            }
        }
    }
}