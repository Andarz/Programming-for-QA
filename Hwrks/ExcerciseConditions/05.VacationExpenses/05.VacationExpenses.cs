namespace _05.VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string type = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double res = 0;

            switch (season)
            {
                case "Spring":
                    if (type == "Hotel")
                    {
                        res = days * 30 * 0.8;
                    }
                    else if (type == "Camping")
                    {
                        res = days * 10 * 0.8;
                    }                    
                    break;
                case "Summer":
                    if (type == "Hotel")
                    {
                        res = days * 50;
                    }
                    else if (type == "Camping")
                    {
                        res = days * 30;
                    }
                    break;
                case "Autumn":
                    if (type == "Hotel")
                    {
                        res = days * 20 * 0.7;
                    }
                    else if (type == "Camping")
                    {
                        res = days * 15 * 0.7;
                    }
                    break;
                case "Winter":
                    if (type == "Hotel")
                    {
                        res = days * 40 * 0.9;
                    }
                    else if (type == "Camping")
                    {
                        res = days * 10 * 0.9;
                    }
                    break;
            }
            Console.WriteLine($"{res:f2}");
        }
    }
}