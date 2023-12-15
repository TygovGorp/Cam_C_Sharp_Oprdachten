namespace Opdracht_2
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
            Console.WriteLine("num_3:");
            int num_3 = Convert.ToInt32(Console.ReadLine());

            if (num_1 < num_2 && num_1<num_3)
            {
                Console.WriteLine("jouw v nummer is:");
                Console.WriteLine(num_1);
            }
            else if(num_2<num_3 && num_2<num_1)
            {
                Console.WriteLine("jouw kleinste nummer is:");
                Console.WriteLine(num_2);
            }
            else
            {
                Console.WriteLine("jouw kleinste nummer is:");
                Console.WriteLine(num_3);
            }
        }
    }
}