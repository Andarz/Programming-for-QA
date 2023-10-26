namespace _06.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            for (int currentDay = days; currentDay > 0; currentDay--)
            {
                Console.WriteLine($"{currentDay} days before the exam");
            }
            Console.WriteLine("The exam has come");
        }
    }
}