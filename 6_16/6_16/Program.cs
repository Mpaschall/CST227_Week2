using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int rndNum = 0;
            int headCount = 0;
            double percent = 0;
            Random rnd = new Random(DateTime.Now.Millisecond);

            Console.WriteLine("Enter the number of coin tosses.");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                rndNum = rnd.Next(2);
                if (rndNum == 0)
                {
                    Console.WriteLine("You flipped a head");
                    headCount++;
                }
                else if (rndNum == 1)
                {
                    Console.WriteLine("You flipped a tail");
                }
            }
            percent = ((headCount * 100) / num);
            Console.WriteLine("The percentage that were heads were " + percent + "%.");
        }
    }
}
