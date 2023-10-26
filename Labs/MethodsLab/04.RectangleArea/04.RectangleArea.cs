int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

CalculateArea(width, length);

void CalculateArea(int width, int length)
{
    int area = width * length;
    Console.WriteLine(area);
}
