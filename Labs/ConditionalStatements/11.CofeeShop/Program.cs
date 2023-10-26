namespace _11.CofeeShop
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
            if (extra == "sugar")
            {
                price += 0.40;
            }
            Console.WriteLine("Final price: ${0:f2}", price);
        }
    }
}