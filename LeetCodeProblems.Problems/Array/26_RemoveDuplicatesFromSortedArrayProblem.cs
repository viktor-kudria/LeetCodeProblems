namespace LeetCodeProblems.Problems.Array
{
    /// <summary>
    /// 26. Remove Duplicates from Sorted Array
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    public class RemoveDuplicatesFromSortedArrayProblem
    {

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int i = 0;
            int length = nums.Length;

            for (int j = 1; j < length; j++)
            {
                if (nums[j] != nums[i])
                {
                    nums[++i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}