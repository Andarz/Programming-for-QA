namespace _07.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lett1 = char.Parse(Console.ReadLine());
            char lett2 = char.Parse(Console.ReadLine());

            for (char c  = lett1; c <= lett2; c++)
            {
                Console.Write(c + " ");
            }
        }
    }
}