namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string status = "";

            switch (day)
            {
                case "Monday":
                    if (hour >= 10 && hour <= 18)
                    {
                        status = "open";
                    }
                    else
                        status = "closed";
                    break;
                case "Tuesday":
                    if (hour >= 10 && hour <= 18)
                    {
                        status = "open";
                    }
                    else
                        status = "closed";
                    break;
                case "Wednesday":
                    if (hour >= 10 && hour <= 18)
                    {
                        status = "open";
                    }
                    else
                        status = "closed";
                    break;
                case "Thursday":
                    if (hour >= 10 && hour <= 18)
                    {
                        status = "open";
                    }
                    else
                        status = "closed";
                    break;
                case "Friday":
                    if (hour >= 10 && hour <= 18)
                    {
                        status = "open";
                    }
                    else
                        status = "closed";
                    break;
                case "Saturday":
                    if (hour >= 10 && hour <= 18)
                    {
                        status = "open";
                    }
                    else
                        status = "closed";
                    break;
                default:
                    status = "closed";
                    break;
            }
            Console.WriteLine(status);
        }
    }
}