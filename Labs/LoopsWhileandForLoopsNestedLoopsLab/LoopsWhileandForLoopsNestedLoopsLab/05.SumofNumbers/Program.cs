namespace _05.SumofNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initial = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < initial)
            {
                int initialSec = int.Parse(Console.ReadLine());
                sum += initialSec;
            }
            Console.WriteLine(sum);
        }
    }
}