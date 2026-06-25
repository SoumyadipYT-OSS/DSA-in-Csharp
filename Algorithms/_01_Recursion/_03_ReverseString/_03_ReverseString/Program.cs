
using static System.Console;

namespace _03_ReverseString;


public class Program
{
    public static string RecursiveReverse(string? str)
    {
        return str is null ? throw new ArgumentNullException(nameof(str)) : Algo(str, 0);
    }

    private static string Algo(string str, int idx)
    {
        if (idx >= str.Length)
            return string.Empty;

        return Algo(str, idx + 1) + str[idx];
    } 


    static void Main()
    {
        WriteLine("String Reversal using Recursion in C#");
        Write("Enter a string: ");
        string? input = ReadLine();
        WriteLine(RecursiveReverse(input));
    }
}