

namespace FunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 3
            //List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };
            //numbers.ForEach(num => Console.WriteLine(Exercises001.AddTen(num)));

            // Task 4
            //List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };
            //words.ForEach(word => Console.WriteLine(Exercises001.GrammarCheck(word)));

            // Task 5
            //Console.WriteLine(Exercises001.SumIndices("start", "pale"));

            //Task 6
            //Console.WriteLine(Exercises001.CheckValidEmail("user@northercoders.co.uk"));
            //Console.WriteLine(Exercises001.CheckValidEmail("validuser@northcoders.co.uk"));
            //Console.WriteLine(Exercises001.CheckValidEmail("validUser@gmail.com"));

            //Exercises002.GetUserNames();


            //Task 11
            //List<int> list = new List<int>
            //{
            //    1, 2, 3, 4
            //};

            //List<int> numList = new List<int> { 5, 8, 3, 6, 67 };
            //Exercises002.PrintSquaredNums(numList);

            List<string> emailList = new List<string>
            {
                "alice.yang@northcoders.com",
                "richard.neat@northcoders.com",
                "mario@plumbing.it",
                "link@hyrule.co.uk",
                "shrek@duloc.com",
                "neil.hughes@walkingoncustard.com",
                "csharp@microsoft.cs",
                "ziggy@spidersfrommars.co.uk",
                "lemmy@motorhead.co,uk",
                "me@myhouse.sleep"
            };
            var filteredEmails = Exercises002.FilterEmails(emailList);

            foreach (var item in filteredEmails)
            {
                Console.WriteLine(item.Key);
                item.Value.ForEach(Console.WriteLine);
            }
        }
    }
}
