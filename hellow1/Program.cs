using hellow1;

namespace training
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Menu();
        }
        public static void Menu()
        {
            List<string> list = new List<string>();
            list.Add("1. Flight");
            list.Add("2. Deals");
            list.Add("3. View Cart");


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Pick the number");

            switch (Console.ReadLine())
            {
                case "1":
                    Flight.ListFlight();
                    break;
                case "2":
                    Deals.ListDeals();
                    break;
            }
        }

    }

}