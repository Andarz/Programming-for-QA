namespace GamingScore
{
    internal class GamingScore
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double totalSpent = 0;
            double gamePrice = 0;

            while (true)
            {
                string game = Console.ReadLine();

                

                if (game == "Game Time")
                {
                    break; //some code
                }

                switch (game)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;

                        if (gamePrice > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        balance -= gamePrice;
                        totalSpent += gamePrice;
                        Console.WriteLine($"Bought {game}");
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        
                        if (gamePrice > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        balance -= gamePrice;
                        totalSpent += gamePrice;
                        Console.WriteLine($"Bought {game}");
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        
                        if (gamePrice > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        balance -= gamePrice;
                        totalSpent += gamePrice;
                        Console.WriteLine($"Bought {game}");
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        
                        if (gamePrice > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        balance -= gamePrice;
                        totalSpent += gamePrice;
                        Console.WriteLine($"Bought {game}");
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        
                        if (gamePrice > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        balance -= gamePrice;
                        totalSpent += gamePrice;
                        Console.WriteLine($"Bought {game}");
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        
                        if (gamePrice > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            continue;
                        }
                        balance -= gamePrice;
                        totalSpent += gamePrice;
                        Console.WriteLine($"Bought {game}");
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
          }
    }
}