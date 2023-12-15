namespace Opdracht_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("wat is het nummer van de dag:");
            int num_dag = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("het is vandaag:");
            switch (num_dag)
            {
                case 1:
                    Console.WriteLine("Maandag");
                    break;
                case 2:
                    Console.WriteLine("Dinsdag");
                    break;
                case 3:
                    Console.WriteLine("Woensdag");
                    break;
                case 4:
                    Console.WriteLine("Donderdag");
                    break;
                case 5:
                    Console.WriteLine("Vrijdag");
                    break;
                case 6:
                    Console.WriteLine("Zaterdag");
                    break;
                case 7:
                    Console.WriteLine("Zondag");
                    break;
            }
        }
    }
}