namespace _05.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            
            RepeatString(text, times);
        }

        private static void RepeatString(string text, int times)
        {
            string resultString = "";
            for (int i = 0; i < times; i++)
            {
                resultString += text;
            }

            Console.WriteLine(resultString);
        }
    }
}