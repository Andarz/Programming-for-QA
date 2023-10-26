List<int> elements = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int longestStart = 0;
int longestLength = 1;
int currentStart = 0;
int currentLength = 1;

for (int i = 1; i < elements.Count; i++)
{
    if (elements[i] == elements[i - 1])
    {
        currentLength++;
        if (currentLength > longestLength)
        {
            longestLength = currentLength;
            longestStart = currentStart;
        }
    }
    else
    {
        currentStart = i;
        currentLength = 1;
    }
}

List<int> longestSequence = elements.Skip(longestStart).Take(longestLength).ToList();
Console.WriteLine(string.Join(" ", longestSequence));