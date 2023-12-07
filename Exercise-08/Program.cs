namespace Exercise_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D pointA = new Point2D { X = 2f, Y = 4f };
            Point2D pointB = new Point2D { X = 6f, Y = 8f };


            double distance = DistanceCalculator.CalculateDistance(pointA, pointB);
            Console.WriteLine($"The distance between Point A and Point B is: {distance:F2}");
        }
    }
}
