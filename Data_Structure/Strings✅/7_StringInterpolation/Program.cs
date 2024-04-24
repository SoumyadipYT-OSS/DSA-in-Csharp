using System;

namespace pr7
{
    class q7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__Example 1__");
            var infoMsg = (Brand: "HP", Series: "Omen", ModelNo: 16, ModelName: "Transcend", ReleaseMonth: "June", ReleaseYear: 2023);
            Console.WriteLine($"Brand new {infoMsg.Brand} release its new {infoMsg.Series} series model: {infoMsg.ModelName}{infoMsg.ModelNo}");
            Console.WriteLine($"The model is released on {infoMsg.ReleaseMonth},{infoMsg.ReleaseYear}\n");



            Console.WriteLine("__Example 2__");
            int X = 2;
            int Y = 3;

            var pointMessage = $$"""The point {{{X}}, {{Y}}} is {{Math.Sqrt(X * X + Y * Y)}} from the origin.""";
            Console.WriteLine($"{pointMessage}\n");
        }
    }
}