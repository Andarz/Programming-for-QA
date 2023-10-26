namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= counter; i++)
            {
                double elem = double.Parse(Console.ReadLine());
                sum += elem;
            }
            Console.WriteLine(sum);
        }
    }
}