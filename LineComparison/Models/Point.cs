namespace LineComparison.Models
{
    // Represents a point in 2D space
    public class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
