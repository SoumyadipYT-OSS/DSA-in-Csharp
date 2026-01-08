
using System;

namespace _04_QuickSort;

public class Algorithm
{
    private static readonly Random random = new();

    public static void QuickSort(int[] arr)
    {
        if (arr is null || arr.Length <= 1)
            return;

        Algo(arr, 0, arr.Length - 1);
    }


    private static void Algo(int[] a, int left, int right)
    {
        while (left < right) {
            int p = PartitionHoare(a, left, right);
            if (p - left < right - (p + 1)) {
                Algo(a, left, p);
                left = p + 1;
            }
            else {
                Algo(a, p + 1, right);
                right = p;
            }
        }
    }


    private static int PartitionHoare(int[] arr, int left, int right)
    {
        int pivotIndex = left + random.Next(right - left + 1);
        int pivot = arr[pivotIndex];

        int i = left - 1;
        int j = right + 1;

        while (true) {
            do {
                i++;
            } while (arr[i] < pivot);
            do {
                j--;
            } while (arr[j] > pivot);

            if (i >= j)
                return j;

            (arr[i], arr[j]) = (arr[j], arr[i]);
        }
    }
}