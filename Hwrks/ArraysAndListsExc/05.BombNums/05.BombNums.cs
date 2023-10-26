List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> bomb = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int bombNum = bomb[0];
int bombPower = bomb[1];

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == bombNum)
    {
        int start = i - bombPower;
        int toRemove = bombPower + bombPower + 1;

        if (start < 0)
        {
            toRemove += start;
            start = 0;
        }
        if (toRemove > numbers.Count - start)
        {
            toRemove = numbers.Count - start;
        }
        numbers.RemoveRange(start, toRemove);
        i = -1; 
    }
}
//Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(numbers.Sum());

