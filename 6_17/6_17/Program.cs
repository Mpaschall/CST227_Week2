using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int dartThrow = 0;
            double x = 0;
            double y = 0;
            int hitCount = 0;
            int numDart = 0;
            double estimPie = 0;
            Random rnd = new Random(DateTime.Now.Millisecond);
                        
            Console.WriteLine("How many darts will you throw?");
            numDart = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numDart; i++)
            {
                x = rnd.Next(10);
                y = rnd.Next(10);
                if (((x - 0.5) * 2) + ((y - 0.5) * 2) < .25)
                {
                    Console.WriteLine("The dart hit the circle.");
                    hitCount++;
                }
                else
                {
                    Console.WriteLine("The dart didn't hit the circle.");
                }
            }
            estimPie = ((hitCount * 4) / numDart);
            Console.WriteLine("Estimated pi is " + estimPie);
        }
    }
}
