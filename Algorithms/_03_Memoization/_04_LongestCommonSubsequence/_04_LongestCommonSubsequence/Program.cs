
using static System.Console;

namespace _04_LongestCommonSubsequence;

public class Program
{
    static void Main()
    {
        WriteLine("Longest Common Subsequence using Memoization");
        string str1 = "AGGTAB";
        string str2 = "GXTXAYB";
        WriteLine($"string1: {str1} \t string2: {str2}");
        WriteLine($"Output: {Algorithm.LCS(str1, str2)}");
    }
}