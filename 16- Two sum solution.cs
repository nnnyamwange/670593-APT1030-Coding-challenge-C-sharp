using System;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        int closestSum = int.MaxValue;
        int[] closestPair = null!;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int sum = nums[i] + nums[j];
                int difference = Math.Abs(target - sum);

                if (difference < closestSum)
                {
                    closestSum = difference;
                    closestPair = new int[] { i, j };
                }
            }
        }

        return closestPair;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = solution.TwoSum(nums, target);
        if (result != null)
        {
            Console.WriteLine($"Indices of the numbers that add up to {target}: {result[0]}, {result[1]}");
        }
        else
        {
            Console.WriteLine("No exact pair found.");
        }

        int[] numsForClosest = { 1, 5, 10, 20 };
        int targetForClosest = 12;

        int[] closestResult = solution.TwoSum(numsForClosest, targetForClosest);
        if (closestResult != null)
        {
            Console.WriteLine($"Indices of the closest pair to {targetForClosest}: {closestResult[0]}, {closestResult[1]}");
        }
        else
        {
            Console.WriteLine("No closest pair found.");
        }
    }
}
