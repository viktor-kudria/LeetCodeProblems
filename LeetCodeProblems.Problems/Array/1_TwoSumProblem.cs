using System.Collections.Generic;

namespace LeetCodeProblems.Problems.Array
{
    /// <summary>
    /// 1. Two Sum problem
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSumProblem
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[] {0, 0};
            var dict = new Dictionary<int, int>();
            int dif;

            for (int i = 0; i < nums.Length; i++)
            {
                dif = target - nums[i];

                if (dict.ContainsKey(dif))
                {
                    result[0] = dict[dif];
                    result[1] = i;
                }
                else
                {
                    dict.TryAdd(nums[i], i);
                }
            }

            return result;
        }
    }
}