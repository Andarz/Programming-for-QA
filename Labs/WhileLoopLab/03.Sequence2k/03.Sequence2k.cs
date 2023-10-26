namespace _03.Sequence2k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());
            int current = 1;
            
            while (current <= maxNum)
            {
                Console.WriteLine(current);
                current = current * 2 + 1;

            }
        }
    }
}