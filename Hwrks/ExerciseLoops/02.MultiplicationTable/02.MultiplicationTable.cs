namespace _02.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int res = 0;
            int i = 0;

            for (i = 1; i <= 10; i++) 
            {
                res = n * i;
                Console.WriteLine($"{n} x {i} = {res}");
            }

        }
    }
}