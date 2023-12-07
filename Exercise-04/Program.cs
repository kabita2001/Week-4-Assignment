namespace Exercise_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle { Radius = 5 };

            Console.WriteLine($"The area is : {circle.Calculatearea()}");
        }
    }
}