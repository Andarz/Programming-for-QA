namespace _12.CoffeeShopChecks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            string extra = Console.ReadLine();
            double price = 0;
            if (order == "coffee")
            {
                price = 1.00;
            }
            else if (order == "tea")
            {
                price = 0.60;
            }
            else
            {
                Console.WriteLine("Unknown drink");
                return;
            }
            if (extra == "sugar")
            {
                price += 0.40;
            }
            else if (extra == "no")
            {
                price = price * 1.00;
            }
            else
            {
                Console.WriteLine("Unknown extra");
                return;
            }
            Console.WriteLine("Final price: ${0:f2}", price);
        }
    }
}