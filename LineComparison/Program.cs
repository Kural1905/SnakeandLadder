using System;
using LineComparison.Models;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program ");

            // UC1: Calculate length
            var point1 = new Point(0, 0);
            var point2 = new Point(3, 4); // Length = 5
            var line1 = new Line(point1, point2);

            var point3 = new Point(1, 1);
            var point4 = new Point(4, 5); // Length = 5
            var line2 = new Line(point3, point4);

            Console.WriteLine($"Line 1 Length: {line1.Length:F2}");
            Console.WriteLine($"Line 2 Length: {line2.Length:F2}");

            // UC2: Check equality
            Console.WriteLine($"UC2 Are both lines equal? {line1.Equals(line2)}");

            // UC3 & UC4: Compare lines
            int compareResult = line1.CompareTo(line2);
            string result;
            switch (compareResult)
            {
                case 0:
                    result = "Both lines are equal in length";
                    break;
                default:
                    if (compareResult > 0)
                        result = "Line 1 is longer than Line 2";
                    else
                        result = "Line 1 is shorter than Line 2";
                    break;
            }

            Console.WriteLine($"UC3 Line Comparison Result: {result}");
        }
    }
}
