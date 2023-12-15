namespace Opdracht_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("vak 1 gemiddelde:");
            double vak_1_gem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vak 2 gemiddelde:");
            double vak_2_gem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vak 3 gemiddelde:");
            double vak_3_gem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vak 4 gemiddelde:");
            double vak_4_gem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vak 5 gemiddelde:");
            double vak_5_gem = Convert.ToDouble(Console.ReadLine());

            double tot_gem = (vak_1_gem + vak_2_gem + vak_3_gem + vak_4_gem + vak_5_gem) / 5;

            int numOnvoldoende = 0;

            if (vak_1_gem < 5.5) numOnvoldoende++;
            if (vak_2_gem < 5.5) numOnvoldoende++;
            if (vak_3_gem < 5.5) numOnvoldoende++;
            if (vak_4_gem < 5.5) numOnvoldoende++;
            if (vak_5_gem < 5.5) numOnvoldoende++;

            if (tot_gem >= 5.5f && numOnvoldoende <= 2)
            {
                Console.WriteLine("je gaat over");
            }
            else
            {
                Console.WriteLine("je gaat niet over");
            }
        }
    }
}