int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

CheckAndPrintMultiplicationSign(num1, num2, num3);

static void CheckAndPrintMultiplicationSign(int num1, int num2, int num3)
{
    if (num1 == 0
        || num2 == 0
        || num3 == 0)
    {
        Console.WriteLine("zero");
    }
    if ((num1 > 0 && num2 > 0 && num3 > 0)
        || (num1 < 0 && num2 < 0 && num3 > 0)
        || (num1 > 0 && num2 < 0 && num3 < 0)
        || (num1 < 0 && num2 > 0 && num3 < 0))
    {
        Console.WriteLine("positive");
    }
    if ((num1 < 0 && num2 < 0 && num3 < 0)
        || (num1 > 0 && num2 > 0 && num3 < 0)
        || (num1 < 0 && num2 > 0 && num3 > 0)
        || (num1 > 0 && num2 < 0 && num3 > 0))
    {
        Console.WriteLine("negative");
    }
}

