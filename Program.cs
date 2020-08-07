using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQsyntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            var result = values.Where(v => v < 37).OrderByDescending(v => v);
            //IEnumerable<int> result = from v in values where v < 37 orderby -v select v;
            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }
            //            var random = new Random();
            //            var numbers = new List<int>();
            //            int length = random.Next(50, 150);
            //            for (int i = 0; i < length; i++)
            //                numbers.Add(random.Next(100));

            //            Console.WriteLine($@"Stats for these {numbers.Count()} numbers:
            //The first 5 numbers: {String.Join(", ", numbers.Take(5))}
            //The last 5 numbers: {String.Join(", ", numbers.TakeLast(5))}
            //The first is {numbers.First()} and the last is {numbers.Last()}
            //The smallest is {numbers.Min()}, and the biggest is {numbers.Max()}
            //The sum is {numbers.Sum()}
            //The average is {numbers.Average():F2}");
            Console.ReadLine();
        }
    }
}
