using System;
using static System.Console;


class BinarSearchClass 
{
    public static int BinarySearchAlgo(int[] list, int item) 
    {
        int low = 0;
        int high = list.Length - 1;

        while (low <= high) {
            int mid = (low + high) / 2;
            int guess = list[mid];

            if (guess == item)
                return mid;
            else if (guess < item)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return 0;
    }
}


class _01_BubbleSort 
{
    static void Main() 
    {
        int[] integerList = { 12, 15, 16, 18, 20 };
        int target = 16;

        WriteLine(string.Join(", ", integerList));
        WriteLine($"Target: {target}");
        WriteLine($"Found at index: {BinarSearchClass.BinarySearchAlgo(integerList, target)}");
    }
}