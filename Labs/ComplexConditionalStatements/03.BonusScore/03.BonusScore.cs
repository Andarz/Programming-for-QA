namespace _03.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int BonusScore = 0;

            if (0 <= input && input <= 3)
            {
                input += 5;
            }
            else if (4 <= input && input <= 6)
            {
                input += 15;
            }
            else if (7 <= input && input <= 9)
            {
                input += 20;
            }
            Console.WriteLine(input);
        }
    }
}
