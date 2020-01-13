namespace LeetCodeProblems.Problems.Array
{
    public class MaximumSubarrayProblem
    {
        public int MaxSubArray(int[] nums)
        {
            return Calculate2(nums, 0, nums.Length - 1);
        }

        private int Calculate(int[] nums, int startIndex, int endIndex)
        {
            int sum = 0;
            if (startIndex == endIndex) return nums[startIndex];

            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += nums[i];
            }

            int leftSum = Calculate(nums, startIndex, endIndex - 1);
            int rightSum = Calculate(nums, startIndex + 1, endIndex);

            if (sum > leftSum)
            {
                return sum > rightSum ? sum : rightSum;
            }

            return leftSum > rightSum ? leftSum : rightSum;
        }

        private int Calculate2(int[] nums, int startIndex, int endIndex)
        {
            int sum = 0;
            int deepSum = 0;
            if (startIndex == endIndex) return nums[startIndex];

            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += nums[i];
            }

            int leftSum = sum - nums[endIndex];
            int rightSum = sum - nums[startIndex];

            if (leftSum > rightSum)
            {
                int calc = Calculate2(nums, startIndex, endIndex - 1);
                deepSum = leftSum > calc ? leftSum : calc;
            }
            else if (rightSum > leftSum)
            {
                int calc = Calculate2(nums, startIndex + 1, endIndex);
                deepSum = rightSum > calc ? rightSum : calc;
            }
            else
            {
                int calcLeft = Calculate2(nums, startIndex, endIndex - 1);
                int calcRight = Calculate2(nums, startIndex + 1, endIndex);

                int calc = calcLeft > calcRight ? calcLeft : calcRight;
                deepSum = rightSum > calc ? rightSum : calc;
            }

            return sum > deepSum ? sum : deepSum;
        }

        private int Calculate3(int[] nums, int startIndex, int endIndex)
        {
            
        }
    }
}