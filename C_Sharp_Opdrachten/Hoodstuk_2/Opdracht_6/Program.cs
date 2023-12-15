namespace Opdracht_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int i = 0;
            int printDit = 0;
            while (i <= 10)
            {
                printDit += i;
                Console.WriteLine(printDit);
                i++;
            }
        }
    }
}