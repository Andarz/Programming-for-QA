//string input = Console.ReadLine();
//string[] items = input.Split(" ");
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int res = 0;
foreach (int n in numbers)
{
    res += n;
}
Console.WriteLine(res);