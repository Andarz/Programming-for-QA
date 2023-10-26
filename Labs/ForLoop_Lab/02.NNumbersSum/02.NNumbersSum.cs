namespace _02.NNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum += i;
                Console.Write($"{i}");

                if (i < num)
                {
                    Console.Write("+");
                }
                else
                    Console.WriteLine($"={sum}");
            }
        }
    }
}