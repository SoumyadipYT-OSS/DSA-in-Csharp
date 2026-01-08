
namespace _04_LongestCommonSubsequence;

public class Algorithm
{
    public static int LCS(string x, string y)
    {
        int m = x.Length, n = y.Length;
        int[,] memory = new int[m, n];

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                memory[i, j] = -1;

        return LongestCommonSubsequenceHelper(x, y, 0, 0, memory);
    }

    private static int LongestCommonSubsequenceHelper(string s1, string s2, int i, int j, int[,] memo) 
    {
        if (i >= s1.Length || j >= s2.Length)
            return 0;

        else if (memo[i, j] != -1)
            return memo[i, j];

        else if (s1[i] == s2[j])
            memo[i, j] = 1 + LongestCommonSubsequenceHelper(s1, s2, i + 1, j + 1, memo);

        else {
            memo[i, j] = Math.Max(
                    LongestCommonSubsequenceHelper(s1, s2, i + 1, j, memo),
                    LongestCommonSubsequenceHelper(s1, s2, i, j + 1, memo)
            );
        }

        return memo[i, j];
    }
}