int[] firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
int[] secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

foreach (int elem in firstArr)
{
    for (int i = 0; i <= secondArr.Length - 1; i++)
    {
        if (elem == secondArr[i])
        {
            Console.Write (secondArr[i] + " ");
        }
    }
}