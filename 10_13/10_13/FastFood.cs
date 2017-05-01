using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_13
{
    class FastFood: Restaurant
    {
        string entered = "";
        static double count = 0;
        static List<string> list = new List<string>();
              
        public static void GetMenu()
        {
            Console.WriteLine("Billboard shows: Hamburger - $2.00, Fries - $1.00, Soda - $1.00");
        }

        public static void OrderFood()
        {
            Console.WriteLine("Machine says: What would you like to order? -1 to complete order");
            string entered = Console.ReadLine();
            while (entered != "-1")
            {
                for (int i = 0; i < 100; i++)
                {
                    if (entered.Equals("Hamburger"))
                    {
                        count += 1.00;
                        list[i] = entered;
                    }
                    else if (entered.Equals("Fries"))
                    {
                        count += 1.00;                     
                        list[i] = entered;
                    }
                    else if (entered.Equals("Soda"))
                    {
                        count += 1.00;                       
                        list[i] = entered;
                    }
                }
            }
        }

        public static void GetBill()
        {
            for (int j = 0; j < list.Count; j++)
            {
                Console.WriteLine("Machine says: Your items are " + list[j]);
                Console.WriteLine("Machine says: Your total is " + count);
            }
        }

        public static void PayBill()
        {           
            Console.WriteLine("You have paid $" + count + ".");
        }
        public static void EatOut()
        {
            GetMenu();
            OrderFood();
            GetBill();
            PayBill();
        }
    }
}
