
namespace _03_GridUniquePath;

public class Algorithm
{
    public static int FindGridUniquePath(int m, int n)
    {
        if (m <= 0 || n <= 0)
            return 0;

        int[,] memory = new int[m, n];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                memory[i, j] = -1;

        return GridUniquePathHelper(0, 0, m, n, memory);
    }

    private static int GridUniquePathHelper(int i, int j, int m, int n, int[,] memo)
    {
        if (i >= m || j >= n)
            return 0;
        else if (i == m - 1 && j == n - 1)
            return 1;
        else if (memo[i, j] != -1)
            return memo[i, j];
        else {
            memo[i, j] = GridUniquePathHelper(i + 1, j, m, n, memo) + GridUniquePathHelper(i, j + 1, m, n, memo);
            return memo[i, j];
        }
    }
}