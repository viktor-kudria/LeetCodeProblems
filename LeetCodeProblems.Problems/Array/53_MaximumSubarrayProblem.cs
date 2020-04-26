namespace LeetCodeProblems.Problems.Array
{
    public class MaximumSubarrayProblem
    {
        public int MaxSubArray(int[] nums)
        {
            return Kadane(nums);
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
    }
}