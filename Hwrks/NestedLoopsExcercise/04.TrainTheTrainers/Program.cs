namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalStudentGrade = 0;
            int gradeCount = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finish")
                    break;
                string presName = input;
                double totalPresGrade = 0;

                for (int i = 1; i <= n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    totalPresGrade += grade;
                    gradeCount++;
                }
                totalStudentGrade += totalPresGrade;
                double avPresGrade = totalPresGrade / n;
                Console.WriteLine($"{presName} - {avPresGrade:f2}.");
            }
            Console.WriteLine($"Student's final assessment is {(totalStudentGrade / gradeCount):f2}.");
        }
    }
}