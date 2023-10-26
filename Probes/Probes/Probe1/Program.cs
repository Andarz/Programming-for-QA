namespace Probe1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> a = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            List<int> b = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            List<int> result = a.Where(elem => b.Contains(elem)).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}