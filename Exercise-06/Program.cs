namespace Exercise_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(30);
            intStack.Push(40);
            intStack.Push(50);
            intStack.Pop();
            intStack.Push(40);
            intStack.Pop();

            
            Console.WriteLine("Remaining items in the stack:");
            while (!intStack.IsEmpty())
            {
                Console.WriteLine(intStack.Pop());
            }
        }
    }
}