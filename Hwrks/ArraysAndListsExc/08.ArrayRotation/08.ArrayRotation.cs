List<int> numberline = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int n = int.Parse(Console.ReadLine());

while (n > 0)
{
    for (int i = 0; i < n; i++)
    {
        numberline.Add(numberline[i]);
        numberline.Remove(numberline[i]);
        i = -1;
        n--;
    }    
}
Console.WriteLine(string.Join(" ", numberline));