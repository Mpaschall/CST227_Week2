using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_13
{
    class Program: Restaurant
    {
       
        static void Main(string[] args)
        {
            string place = "";
            Console.WriteLine("Where would you like to eat? fastfood, coffee, fancy");
            place = Console.ReadLine();
            if (place.Equals("fastfood"))
            {
                FastFood.EatOut();
            }
            else if (place.Equals("coffee"))
            {
                CoffeeShop.EatOut();
            }
            else if (place.Equals("fancy"))
            {
                Fancy.EatOut();
            }
            
            
           
        }
    }
}
