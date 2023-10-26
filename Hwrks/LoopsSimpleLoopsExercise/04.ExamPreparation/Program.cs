namespace _04.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGradeMax = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int badGradeCount = 0;
            int problemCount = 0;
            double gradeSum = 0;
            double avScore = 0;
            string currProblem = "";

            while (input != "Enough")
            {                
                int grade = int.Parse(Console.ReadLine());
                problemCount++;
                gradeSum += grade;
                currProblem = input;

                if (grade <= 4)
                {
                    badGradeCount++;
                }
                if (badGradeCount == badGradeMax)
                {
                    Console.WriteLine($"You need a break, {badGradeCount} poor grades.");
                    return;
                }
                input = Console.ReadLine();
            }
                avScore = gradeSum / problemCount;
                Console.WriteLine($"Average score: {avScore:f2}");
                Console.WriteLine($"Number of problems: {problemCount}");
                Console.WriteLine($"Last problem: {currProblem}");
        }
    }
}