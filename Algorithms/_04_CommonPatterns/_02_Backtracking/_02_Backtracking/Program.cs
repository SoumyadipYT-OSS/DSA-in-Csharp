/*
=========================================================================
                BACKTRACKING
=========================================================================

           --------
  Generate all subsets (Power Set) - Easy
           --------
*/


class Program
{
    static void Subsets(int[] nums, int index, List<int> current, List<List<int>> result)
    {
        if (index == nums.Length) {
            result.Add([.. current]);
            return;
        }

        Subsets(nums, index + 1, current, result);

        current.Add(nums[index]);
        Subsets(nums, index + 1, current, result);
        current.RemoveAt(current.Count - 1); // Backtrack
    }


    static void Main()
    {
        int[] nums = { 1, 2, 3 };
        var result = new List<List<int>>();
        Subsets(nums, 0, [], result);

        foreach (var subset in result)
            Console.WriteLine(string.Join(", ", subset));
    }
}