using static System.Console;

namespace _01_Permutation_of_String;


public class Program
{
    static void Main()
    {
        string inputString = "ABC";
        int n = inputString.Length;

        WriteLine($"Permutation of string '{inputString}': ");
        Algorithm algo = new();
        algo.Permute(inputString, 0, n - 1);
    }
}