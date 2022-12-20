using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hellow1
{
    public class Cart
    {
        public void ListCart()
        {
            List<string> list = new List <string>();
            list.Add("CART LIST");
            

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        internal void AddToCart(int v)
        {
            Console.WriteLine($"{v} selected");
        }
    }
}
