
using static System.Console;
using System.Diagnostics;

namespace _01_FibonacciSeries;

public class Program
{
    static void Main()
    {
        int n = 40;

        Stopwatch memoTimeStats = new();
        memoTimeStats.Start();
        long memoResult = Algorithm.FibonacciMemoization(n);
        memoTimeStats.Stop();
        long memoElapsedTime = memoTimeStats.ElapsedMilliseconds;
        WriteLine($"Result: {memoResult}");
        WriteLine($"Elapsed Time: {memoElapsedTime}");

        Stopwatch naiveTimeStats = new();
        naiveTimeStats.Start();
        long naiveResult = Algorithm.FibonacciNaive(n);
        naiveTimeStats.Stop();
        long naiveElapsedTime = naiveTimeStats.ElapsedMilliseconds;
        WriteLine($"Result: {naiveResult}");
        WriteLine($"Elapsed Time: {naiveElapsedTime}");
    }
}