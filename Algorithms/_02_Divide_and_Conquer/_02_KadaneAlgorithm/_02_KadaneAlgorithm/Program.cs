using static System.Console;

namespace _02_KadaneAlgorithm;


public class Program
{
    static void Main()
    {
        WriteLine("Maximum subarray sum problem using Kadane's Algorithm");
        WriteLine("1. Directly using Kadane's algorithm taking time complexity O(n)");
        int[] array1 = { -2, 0, -1, 5, 2, -3, 6, 4 };
        WriteLine(Algorithm.Kadane(array1));

        WriteLine("2. Using Divide and Conquer Kadane's algorithm approach taking time complexity O(NlogN)");
        WriteLine(Algorithm.KadaneAlgo_Divide_and_Conquer(array1));
    }
}