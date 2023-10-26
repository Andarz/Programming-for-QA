namespace ExerciseLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int res = 1;

            for (int i = 1; i <= p;  i++) 
            {
                res *= n;
            }

            Console.WriteLine(res);
        }
    }
}