List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

for (int i = 0; i < numbers.Count - 1; i++)
{
    int num1 = numbers[i];
    int num2 = numbers[i + 1];
    if (num1 == num2)
    {
        numbers[i] = num1 + num2;
        numbers.RemoveAt(i + 1);
        i = -1;
    }    
}

Console.WriteLine(string.Join(" ", numbers));