namespace _09.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secs1 = int.Parse(Console.ReadLine());
            int secs2 = int.Parse(Console.ReadLine());
            int secs3 = int.Parse(Console.ReadLine());

            int totalSecs = secs1 + secs2 + secs3;
            int mins = totalSecs / 60;
            int restSecs = totalSecs % 60;

            Console.WriteLine($"{mins}:{restSecs:D2}");
            
        }
    }
}