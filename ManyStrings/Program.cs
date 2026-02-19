using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string testingEmoji ="this be an emoji \u2622";
            string unicode = "this is a \t tab ";
        
            Console.WriteLine(testingEmoji);
            Console.WriteLine(unicode);

        }
    }
}
