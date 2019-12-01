namespace LeetCodeProblems.Problems.Array
{
    /// <summary>
    /// 27. Remove Element
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    public class RemoveElementProblem
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;

            int indexToPut = nums.Length - 1;
            int length = 0;
            for (int i = 0; i < nums.Length && i <= indexToPut; i++)
            {
                if (nums[i] == val)
                {
                    while (nums[indexToPut] == val)
                    {
                        if (indexToPut == i) return length;

                        indexToPut--;
                    }

                    nums[indexToPut] = nums[indexToPut] + nums[i];
                    nums[i] = nums[indexToPut] - nums[i];
                    nums[indexToPut] = nums[indexToPut] - nums[i];

                    length++;
                }
                else
                {
                    length++;
                }
            }

            return length;
        }
    }
}