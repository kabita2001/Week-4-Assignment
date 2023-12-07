namespace Exercise_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(4.5f,3.2f);
            float area = rec.CalculateArea();
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}