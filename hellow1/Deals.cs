using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training;

namespace hellow1
{
    public class Deals
    {
        public static void ListDeals()
        {
            List<string> list = new List <string>();
            list.Add("DEALS LIST");
            list.Add("1. Hotel Nusa Dua");
            list.Add("2. Hotel California");
            list.Add("x. Back");
            list.Add("0. Add To Cart");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Pick the number");
            
            switch (Console.ReadLine())
            {
                case "x":
                    Program.Menu();
                    break;
                //case "0":
                //    deals.ListCart();
                //    break;
            }
        }
    }
}
