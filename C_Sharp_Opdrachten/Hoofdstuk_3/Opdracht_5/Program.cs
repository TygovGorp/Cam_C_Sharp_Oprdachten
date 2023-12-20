namespace Opdracht_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Vul hier je antwoord in:
             * z = 0.449
             * 
             */

            int x = 10;
            int y = 21;
            double z = 2.0;


            for (int i = 0; i < Convert.ToInt32(Math.PI * 5.32); i++)
            {
                x -= y;
                y += Convert.ToInt32((Math.PI * x)) - x;
                z = y / z;
                Console.WriteLine(z);
            }
        }
    }
}