using System;

namespace pr17
{
    class q17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_String Interpolation_");
            string part1 = "This is";
            string part2 = "an apple";
            string sentence = $"Sentence: {part1} {part2}";
            Console.WriteLine(sentence + "\n");
        }
    }
}