using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training;

namespace hellow1
{
    public class Flight
    {
        public static void ListFlight()
        {
            List<string> flights = new List <string>();
            //list.Add("FLIGHT LIST");
            flights.Add("1. Nusa Dua Airline");
            flights.Add("2. California Airline");
            //list.Add("x. Back");
            //list.Add("0. Add To Cart");

            Console.WriteLine("FLIGHT LIST");
            

            foreach (var item in flights)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine("Pick the number. Press X to back. Press 0 to Complete Cart");
               
            Cart cart= new Cart();

            switch (Console.ReadLine())
            {
                case "x":
                    Program.Menu();
                    break;
                case "0":
                    cart.ListCart();
                    break;
                case "1":
                    cart.AddToCart(1);
                    break;
                case "2":
                    cart.AddToCart(2);
                    break;
            }
        }
    }
}
