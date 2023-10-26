int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);

int print = GetMultipleOfEvenAndOdds(number);
Console.WriteLine(print);

int GetMultipleOfEvenAndOdds(int number)
{
    int sumEven = GetSumOfEvenDigits(number);
    int sumOdd = GetSumOfOddDigits(number);

    int result = sumEven * sumOdd;
    return result;
}

int GetSumOfOddDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;

        if (digit % 2 != 0)
        {
            sum += digit;
        }
        number /= 10;
    }
    return sum;
}

int GetSumOfEvenDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;

        if (digit % 2 == 0)
        {
            sum += digit;
        }
        number /= 10;
    }
    return sum;
}