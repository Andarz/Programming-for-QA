namespace _10.SummerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            string clothing = "Shirt";
            string shoes = "Moccasins";

            if ((temp > 18 && temp <= 24
                && dayTime == "Afternoon")
                || ((temp >= 25)
                && dayTime == "Morning"))
            {
                clothing = "T-Shirt";
                shoes = "Sandals";
            }
            else if (temp >= 10 && temp <= 18 && dayTime == "Morning")
            {
                clothing = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (temp >= 25 && dayTime == "Afternoon")
            {
                clothing = "Swim Suit";
                shoes = "Barefoot";
            }
            Console.WriteLine($"It's {temp} degrees, get your {clothing} and {shoes}.");

        }
    }
}
