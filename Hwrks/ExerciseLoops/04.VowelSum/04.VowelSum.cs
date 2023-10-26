namespace _04.VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int value = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string vowel = Console.ReadLine();

                switch (vowel)
                {
                    case "a":
                        value = 1; break;
                    case "e":
                        value = 2; break;
                    case "i":
                        value = 3; break;
                    case "o":
                        value = 4; break;
                    case "u":
                        value = 5; break;
                    default: value = 0; break;
                }

                sum += value;
            }

            Console.WriteLine(sum);
        }
    }
}