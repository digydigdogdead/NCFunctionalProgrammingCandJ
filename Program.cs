namespace FunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };

            numbers.ForEach(num => Console.WriteLine(Exercises001.AddTen(num)));
        }
    }
}
