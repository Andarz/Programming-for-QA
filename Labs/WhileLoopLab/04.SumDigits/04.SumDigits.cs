namespace _04.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int sum = 0;
            int count = n.Length;

            while (count > 0)
            {
                foreach (char c in n)
                {
                    int num = int.Parse(c.ToString());
                    sum += num;
                    count -= 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}