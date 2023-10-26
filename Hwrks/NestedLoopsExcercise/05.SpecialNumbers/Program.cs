namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1111; number <= 9999;  number++)
            {
                string digits = number.ToString();
                bool isSpecial = true;

                foreach (char c in digits)
                {
                    int digit = int.Parse(c.ToString());
                    
                    if (digit == 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    if (n % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }
                if (isSpecial)
                    Console.Write(number + " ");
            }
        }
    }
}