namespace _06.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            numberPower(number, power);
        }

        private static void numberPower(int number, int power)
        {
            double result = Math.Pow(number, power);
            Console.WriteLine(result);
        }
    }
}