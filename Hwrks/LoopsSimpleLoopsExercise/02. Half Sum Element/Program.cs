namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                sum += numbers[i];

                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            int diff = Math.Abs(maxNumber - (sum - maxNumber));

            if (sum - maxNumber == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNumber);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);

            }
        }
    }
}