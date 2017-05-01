using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_13
{
    class CoffeeShop
    {
        string entered = "";
        static double count = 0;
        static List<string> list = new List<string>();

        public static void GetMenu()
        {
            Console.WriteLine("Menu shows: Large - $3.00, Medium - $2.00, Small - $1.00");
        }

        public static void OrderFood()
        {
            Console.WriteLine("Cashier says: What would you like to order? -1 to complete order");
            string entered = Console.ReadLine();
            while (entered != "-1")
            {
                for (int i = 0; i < 100; i++)
                {
                    if (entered.Equals("Large"))
                    {
                        count += 3.00;
                        list[i] = entered;
                    }
                    else if (entered.Equals("Medium"))
                    {
                        count += 2.00;
                        list[i] = entered;
                    }
                    else if (entered.Equals("Small"))
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
                Console.WriteLine("Cashier says: Your items are " + list[j]);
                Console.WriteLine("Cashier says: Your total is " + count);
            }
        }

        public static void PayBill()
        {
            Console.WriteLine("Thank you, you paid $" + count + ".");
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
