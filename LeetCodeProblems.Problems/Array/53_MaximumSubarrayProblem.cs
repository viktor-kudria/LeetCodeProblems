using System;

namespace LeetCodeProblems.Problems.Array
{
    public class MaximumSubarrayProblem
    {
        public int MaxSubArray(int[] nums)
        {
            return DivideAndConquer(nums);
        }

        private int Kadane(int[] nums)
        {
            int bestSum = int.MinValue;
            int currentSum = 0;

            foreach (var num in nums)
            {
                currentSum = currentSum + num > num ? currentSum + num : num;
                bestSum = currentSum > bestSum ? currentSum : bestSum;
            }

            return bestSum;
        }

        private int DivideAndConquer(int[] nums)
        {
            if (nums.Length == 0) return 0;

            return MaxSubArray(nums, 0, nums.Length - 1);

            int MaxSubArray(int[] arr, int left, int right)
            {
                if (left == right) return arr[left];

                var middle = (left + right) / 2;

                var bestLeft = MaxSubArray(arr, left, middle);
                var bestRight = MaxSubArray(arr, middle + 1, right);

                int leftMax = arr[middle];
                int rightMax = arr[middle + 1];

                int tmp = 0;
                for (int i = middle; i >= left; i--)
                {
                    tmp += arr[i];
                    if (tmp > leftMax) leftMax = tmp;
                }

                tmp = 0;
                for (int i = middle + 1; i <= right; i++)
                {
                    tmp += arr[i];
                    if (tmp > rightMax) rightMax = tmp;
                }

                return Math.Max(Math.Max(bestLeft, bestRight), leftMax + rightMax);
            }
        }
    }
}