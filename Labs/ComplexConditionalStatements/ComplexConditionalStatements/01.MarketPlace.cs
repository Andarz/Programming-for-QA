namespace ComplexConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.0;

            switch (product)
            {
                case "Banana":
                    if (day == "Weekday")
                    {
                        price = 2.50;
                    }
                    else
                        price = 2.70;
                    break;

                case "Kiwi":
                    if (day == "Weekday")
                    {
                        price = 2.20;
                    }
                    else
                        price = 3.00;
                    break;

                case "Apple":
                    if (day == "Weekday")
                    {
                        price = 1.30;
                    }
                    else
                        price = 1.60;
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}