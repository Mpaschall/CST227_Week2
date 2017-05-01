using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_13
{
    class Fancy
    {
        string entered = "";
        static double count = 0;
        static List<string> list = new List<string>();

        public static void GetMenu()
        {
            Console.WriteLine("Fancy menu: Chicken Parm - $25.00, Wine - $10.00, Dessert - $10.00");
        }

        public static void OrderFood()
        {
            Console.WriteLine("Waiter asks: What would you like to order? -1 to complete order");
            string entered = Console.ReadLine();
            while (entered != "-1")
            {
                for (int i = 0; i < 100; i++)
                {
                    if (entered.Equals("Chicken Parm"))
                    {
                        count += 25.00;
                        list.Add("Chicken Parm");
                    }
                    else if (entered.Equals("Wine"))
                    {
                        count += 10.00;
                        list.Add("Wine");
                    }
                    else if (entered.Equals("Dessert"))
                    {
                        count += 10.00;
                        list.Add("Dessert");
                    }
                }
            }
        }

        public static void GetBill()
        {
            for (int j = 0; j < list.Count; j++)
            {
                Console.WriteLine("Check says: Your items are " + list[j]);
                Console.WriteLine("Check says: Your total is " + count);
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
