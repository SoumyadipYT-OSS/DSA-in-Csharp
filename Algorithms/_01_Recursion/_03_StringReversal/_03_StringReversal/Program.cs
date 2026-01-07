using static System.Console;

namespace _03_StringReversal;

public class Program
{
    public static string RecursiveString(string? str)
        => str == null ? throw new ArgumentNullException(nameof(str)) : Algo(str, 0);

    private static string Algo(string str, int idx)
    {
        if (idx >= str.Length)
            return string.Empty;

        return Algo(str, idx + 1) + str[idx];
    }


    static void Main()
    {
        WriteLine("String Reversal in C#");
        Write("Input a string: ");
        string? input = ReadLine();
        WriteLine(RecursiveString(input));
    }
}