List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
string input = Console.ReadLine();

while (input != "end")
{
    if (input.StartsWith("Delete"))
    {
        int element = int.Parse(input.Split(" ")[1]);
        nums.RemoveAll(num => num == element);
    }
    else if (input.StartsWith("Insert"))
    {
        int element = int.Parse(input.Split(" ")[1]);
        int position = int.Parse(input.Split(" ")[2]);
        nums.Insert(position, element);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", nums));
