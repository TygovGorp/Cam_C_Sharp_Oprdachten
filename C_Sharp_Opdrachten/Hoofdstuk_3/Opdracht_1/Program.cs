namespace Opdracht_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool launchReady = false;
            int fuelLevel = 17000;

            if(fuelLevel >= 20000)
            {
                Console.WriteLine("Fuel level cleared.");
                launchReady = true;
            }
            else
            {
                Console.WriteLine("WARNING: Insufficient fuel!");
                launchReady = false;
            }
        }
    }
}