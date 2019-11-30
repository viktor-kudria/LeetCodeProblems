using LeetCodeProblems.Problems.HasTable;
using Xunit;

namespace LeetCodeProblems.Tests.HashTable
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Fact]
        public void Test1()
        {
            var problem = new LongestSubstringWithoutRepeatingCharactersProblem();
            var input = "abcabcbb";
            var actual = problem.LengthOfLongestSubstring(input);
            int expected = 3;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            var problem = new LongestSubstringWithoutRepeatingCharactersProblem();
            var input = "aaaaaa";
            var actual = problem.LengthOfLongestSubstring(input);
            int expected = 1;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            var problem = new LongestSubstringWithoutRepeatingCharactersProblem();
            var input = "pwwkew";
            var actual = problem.LengthOfLongestSubstring(input);
            int expected = 3;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            var problem = new LongestSubstringWithoutRepeatingCharactersProblem();
            var input = "abba";
            var actual = problem.LengthOfLongestSubstring(input);
            int expected = 2;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test5()
        {
            var problem = new LongestSubstringWithoutRepeatingCharactersProblem();
            var input = "tmmzuxt";
            var actual = problem.LengthOfLongestSubstring(input);
            int expected = 5;

            Assert.Equal(expected, actual);
        }
    }
}