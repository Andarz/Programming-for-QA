int n = int.Parse(Console.ReadLine());

List<int> zig = new List<int>();
List<int> zag = new List<int>();

for (int i = 1; i <= n; i++)
{
    List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

    if (i % 2 == 0)
    {
    zig.Add(input[1]);
    zag.Add(input[0]);
    }
    else
    {
        zig.Add(input[0]);
        zag.Add(input[1]);
    }
}

Console.WriteLine(string.Join(" ", zig));
Console.WriteLine(string.Join(" ", zag));