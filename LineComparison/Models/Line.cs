using System;

namespace LineComparison.Models
{
    // Represents a line between two points
    public class Line : IComparable<Line>
    {
        public Point Start { get; }
        public Point End { get; }
        public double Length => CalculateLength();

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        // UC1: Calculate line length using the Euclidean formula
        private double CalculateLength()
        {
            double deltaX = End.X - Start.X;
            double deltaY = End.Y - Start.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        // UC2: Check equality of lines based on length
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != typeof(Line))
                return false;

            var otherLine = (Line)obj;
            return Length.Equals(otherLine.Length);
        }

        public override int GetHashCode()
        {
            return Length.GetHashCode();
        }

        // UC3: Compare lengths of lines
        public int CompareTo(Line other)
        {
            if (other == null) return 1;
            return Length.CompareTo(other.Length);
        }
    }
}
