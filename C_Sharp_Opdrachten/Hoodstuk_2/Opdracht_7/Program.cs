namespace Opdracht_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("een nummer tussen 1 en 10:");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while(i <= 10)
            {
                Console.WriteLine(num*i);
                i++;
            }
        }
    }
}