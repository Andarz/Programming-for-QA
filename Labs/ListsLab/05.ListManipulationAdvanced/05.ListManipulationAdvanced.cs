List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
string input = Console.ReadLine();
List<int> endList = new List<int>();

while (input != "end")
{
    if (input.StartsWith("Contains"))
    {
        int numberIfContains = int.Parse(input.Split(" ")[1]);
        if (nums.Contains(numberIfContains))
        {
            Console.WriteLine("Yes");
        }
        else
            Console.WriteLine("No such number");
    }

    else if (input.StartsWith("PrintEven"))
    {
        Console.WriteLine(String.Join(" ", nums.Where(x => x % 2 == 0)));
    }

    else if (input.StartsWith("PrintOdd"))
    {
        Console.WriteLine(String.Join(" ", nums.Where(x => x % 2 != 0)));
    }

    else if (input.StartsWith("GetSum"))
    {
        Console.WriteLine(nums.Sum());
    }

    else if (input.StartsWith("Filter"))
    {
        string condition = input.Split(" ")[1];
        int number = int.Parse(input.Split(" ")[2]);

        switch (condition)
        {
            case "<":
                Console.WriteLine(String.Join(" ", nums.Where(x => x < number)));
                break;
            case ">":
                Console.WriteLine(String.Join(" ", nums.Where(x => x > number)));
                break;
            case ">=":
                Console.WriteLine(String.Join(" ", nums.Where(x => x >= number)));
                break;
            case "<=":
                Console.WriteLine(String.Join(" ", nums.Where(x => x <= number)));
                break;
        }
    }
    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", endList));
