List<int> seq1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> seq2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> output = new List<int>();

int longerCount = Math.Max(seq1.Count, seq2.Count);

for (int i = 0; i < longerCount; i++)
{
    if (i < seq1.Count)
    {
    output.Add(seq1[i]);
    }

    if (i < seq2.Count)
    {
    output.Add(seq2[i]);
    }
}

Console.WriteLine(string.Join(" ", output));
