namespace Opdracht_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("num_1:");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num_2:");
            int num_2 = Convert.ToInt32(Console.ReadLine());

            if(num_1>num_2)
            {
                Console.WriteLine("jouw grootste nummer is:");
                Console.WriteLine(num_1);
            }
            else
            {
                Console.WriteLine("jouw grootste nummer is:");
                Console.WriteLine(num_2);
            }
        }
    }
}