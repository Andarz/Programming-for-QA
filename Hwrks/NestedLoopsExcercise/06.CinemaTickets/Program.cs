namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSoldTickets = 0;
            double studentTickets = 0;
            double standardTickets = 0;
            double kidTickets = 0;
            double ticketsForMovie = 0;

            while (true)
            {
                string movie = Console.ReadLine() ?? "0";
                int inputSeats = int.Parse(Console.ReadLine() ?? "0");

                while (true)
                {
                    string command = Console.ReadLine() ?? "0";
                    if (command == "End" || ticketsForMovie > inputSeats || inputSeats == 0)
                    {
                        Console.WriteLine($"{movie} - {(ticketsForMovie / inputSeats) * 100:f2}% full.");
                        ticketsForMovie = 0;
                        break;
                    }
                    if (command == "Finish")
                    {
                        Console.WriteLine($"{movie} - {(ticketsForMovie / inputSeats) * 100:f2}% full.");
                        Console.WriteLine($"Total tickets: {totalSoldTickets}");
                        Console.WriteLine($"{(studentTickets / totalSoldTickets) * 100:f2}% student tickets.");
                        Console.WriteLine($"{(standardTickets / totalSoldTickets) * 100:f2}% standard tickets.");
                        Console.WriteLine($"{(kidTickets / totalSoldTickets) * 100:f2}% kids tickets.");
                        return;
                    }
                    switch (command)
                    {
                        case "student":
                            studentTickets++;
                            totalSoldTickets++;
                            ticketsForMovie++;
                            break;

                        case "standard":
                            standardTickets++;
                            totalSoldTickets++;
                            ticketsForMovie++;
                            break;

                        case "kid":
                            kidTickets++;
                            totalSoldTickets++;
                            ticketsForMovie++;
                            break;
                    }
                }
            }
        }
    }
}
