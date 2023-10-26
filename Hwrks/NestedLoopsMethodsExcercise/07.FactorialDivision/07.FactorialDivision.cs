using System.Numerics;

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine((double)CalculateFactorial(num1) / CalculateFactorial(num2));

static int CalculateFactorial(int n)
{
    if (n < 0)
    {
        throw new ArgumentException("Stop");
    }
    if (n == 0 || n == 1)
    {
        return 1;
    }
    BigInteger result = 1;

    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return (int)result;
}
