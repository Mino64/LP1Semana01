using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // number with decimal
            double xx = 1.23456;
            int ii = 19;
            double variable = 1.234;
            float x = MathF.PI;
            string testingEmoji ="this be an emoji \u2622";
            string unicode = "this is a \t tab ";
            string concat = "a"+2;
            string concatPi = "the number of Pi is " + x;

            // f1 = .0 (aka it only goes one behind decimal)
            string interpolation1 = $"x={variable:f1}";

            ///x = number in hex (10 will become a)
            /// 4 and -4 are alignment, 4 will be "4 spaces" before 10 (in hex)
            string interpolation2 = $".{10,4:x}. e .{11,-4:x}";

            ///f2 = .00 (2 behind the decimal)
            /// p1 = .0 % (percentage with one number in decimal)
            /// Percentage is also only between 0 - 1
            string interpolation3 =$"'{5, -6:f2}' e '{0.2:p1}'";

            string realxx = $"xx in decimals= {xx:f2} and percentage= {xx:p1}";
            string hexaii = $"ii in hexa= {ii:x} and ii in moeda= {ii:c}";
        
            Console.WriteLine(testingEmoji);
            Console.WriteLine(unicode);
            Console.WriteLine(concat);
            Console.WriteLine(concatPi);
            Console.WriteLine(interpolation1);
            Console.WriteLine(interpolation2);
            Console.WriteLine(interpolation3);
            Console.WriteLine(realxx);
            Console.WriteLine(hexaii);

        }
    }
}
