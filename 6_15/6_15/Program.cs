using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_15
{
    class Program
    {
        public class Van : IDriveable
        {
            public void aroundTheBlock()
            {
                Console.WriteLine("The van drove around the block.");
            }
        }

        public class SportsCar : IDriveable
        {
            public void aroundTheBlock()
            {
                Console.WriteLine("The sports car drove quickly around the block.");
            }
        }

        static void Main(string[] args)
        {
            Van van = new Van();
            SportsCar car = new SportsCar();

            van.aroundTheBlock();
            car.aroundTheBlock();
        }
    }
}
