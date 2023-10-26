namespace _09.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * length * height;
            int volumeTaken = 0;            

            while (volume >= 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                    break;
                volumeTaken = int.Parse(input);
                volume -= volumeTaken;

            }
            if (volume >= 0)
                Console.WriteLine($"{volume} Cubic meters left.");
            else
                Console.WriteLine($"No more free space! You need {-volume} Cubic meters more.");
        }
    }
}