using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Exercises002
    {
        public static Func<List<string>> GetCoolPeople = () => new List<string>
        {
        "rich.neat@boardgamer.com",
        "poppy.mcdonnell@irishdancer.com",
        "neil.hughes@walkingoncustard.com",
        "alice.yang@midfielder.com",
        "pippa.austin@musician.com"
        };


        public static Action GetUserNames = () =>
        {
            var emails = GetCoolPeople();

            emails.ForEach(email =>
            {
                string username = email.Split('@')[0];
                Console.WriteLine(username);
            });
        };
    }
}
