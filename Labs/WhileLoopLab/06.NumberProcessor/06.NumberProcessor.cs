namespace _06.NumberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "End")
            {
                switch (command)
                {
                    case "Inc":
                        n += 1;
                        break;
                    case "Dec":
                        n -= 1;
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(n);
        }
    }
}