namespace Opdracht_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num3:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num4:");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((num1 + num2 + num3 + num4)/4);
        }
    }
}