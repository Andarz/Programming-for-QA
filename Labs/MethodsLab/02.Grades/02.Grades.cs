﻿namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grd = double.Parse(Console.ReadLine());

            PrintGradesInWords(grd);
        }
        static void PrintGradesInWords(double grade)
        {
            if (grade >= 2.0 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3.0 && grade <= 3.49)
            {
                Console.WriteLine("Average");
            }
            else if (grade >= 3.5 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.5 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else Console.WriteLine("Excellent");
        }
            
    }
        
}
    