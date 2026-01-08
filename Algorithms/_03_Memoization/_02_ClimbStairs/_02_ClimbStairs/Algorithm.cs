
namespace _02_ClimbStairs;

public class Algorithm
{
    public static int ClimbStairs(int n)
    {
        int[] memo = new int[n + 1];

        return ClimbStairsHelper(n, memo);
    }

    private static int ClimbStairsHelper(int i, int[] memo)
    {
        if (i < 0) return 0;

        else if (i == 0 || i == 1) return 1;

        else if (memo[i] != 0)
            return memo[i];

        else {
            memo[i] = ClimbStairsHelper(i - 1, memo) + ClimbStairsHelper(i - 2, memo);
            return memo[i];
        }
    }
}