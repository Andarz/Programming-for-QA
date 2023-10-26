List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
string input = Console.ReadLine();

while (input != "end")
{
    if (input.StartsWith("Add"))
    {
        int element = int.Parse(input.Split(" ")[1]);
        nums.Add(element);
    }
    else if (input.StartsWith("RemoveAt"))
    {
        int index = int.Parse(input.Split(" ")[1]);
        nums.RemoveAt(index);
    }
    else if (input.StartsWith("Remove"))
    {
        int element = int.Parse(input.Split(" ")[1]);
        nums.Remove(element);
    }
    else if (input.StartsWith("Insert"))
    {
        int element = int.Parse(input.Split(" ")[1]);
        int index = int.Parse(input.Split(" ")[2]);
        nums.Insert(index, element);
    }

    input = Console.ReadLine();
}

foreach (int num  in nums)
{
    Console.Write(num + " ");
}
