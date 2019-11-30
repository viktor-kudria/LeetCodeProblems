using System.Collections.Generic;

namespace LeetCodeProblems.Problems.HasTable
{
    public class LongestSubstringWithoutRepeatingCharactersProblem
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            int currentLength = 0;
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] > i - currentLength - 1)
                    {
                        if (currentLength > length)
                        {
                            length = currentLength;
                        }

                        currentLength = i - dict[s[i]];

                        if (currentLength + s.Length - i <= length)
                        {
                            break;
                        }
                    }
                    else
                    {
                        currentLength++;
                    }

                    dict[s[i]] = i;
                }
                else
                {
                    dict.Add(s[i], i);
                    currentLength++;
                }
            }

            if (currentLength > length)
            {
                length = currentLength;
            }

            return length;
        }
    }
}