
namespace _01_FibonacciSeries;

/*
    Added Two Fibonacci
    1. Without Memoization
    2. With Memoization
*/


public class Algorithm
{
    public static long FibonacciNaive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciNaive(n - 1) + FibonacciNaive(n - 2);
    }


    public static long FibonacciMemoization(int n, Dictionary<int, long>? memo = null)
    {
        memo ??= new Dictionary<int, long>();

        if (memo.TryGetValue(n, out long value))
            return value;

        long result;


        if (n <= 1)
            return n;

        else
            result = FibonacciMemoization(n - 1, memo) + FibonacciMemoization(n - 2, memo);

        // storing the result in 'memo' cache
        memo[n] = result;
        return result;
    }
}