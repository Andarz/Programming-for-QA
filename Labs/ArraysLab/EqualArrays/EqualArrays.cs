int[] firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
int[] secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
bool isIdentical = true;

for (int i = 0; i <= firstArr.Length - 1; i++)
{
    if (firstArr[i] != secondArr[i])
    {
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}