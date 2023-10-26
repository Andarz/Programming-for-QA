int num = int.Parse(Console.ReadLine());

DrawTriangle(num);

void DrawTheLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}
void DrawTriangle(int n)
{
    for (int currentLine = 1; currentLine <= n; currentLine++)
    {
        DrawTheLine(1, currentLine);
    }
    for (int currentLine = n - 1; currentLine >= 1; currentLine--)
    {
        DrawTheLine(1, currentLine);
    }
}
