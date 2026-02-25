using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("give me an int number");
            string str = Console.ReadLine();
            int i = Convert.ToInt32(str);

            Console.WriteLine("give me a float number");
            string str2 = Console.ReadLine();
            float f= Convert.ToSingle(str2);

            Console.WriteLine($"{i} + {f} = {i + f}");

        }
    }
}
