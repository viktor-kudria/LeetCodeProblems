using LeetCodeProblems.Problems.Array;
using Xunit;

namespace LeetCodeProblems.Tests.Array
{
    public class TwoSumTests
    {
        [Fact]
        public void Test1()
        {
            var input = new Input()
            {
                Nums = new[] {2, 7, 11, 15},
                Target = 9
            };
            var expected = new [] {0, 1};
            var problem = new TwoSumProblem();

            var actual = problem.TwoSum(input.Nums, input.Target);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2_Negative()
        {
            var input = new Input()
            {
                Nums = new[] { -2, 7, 11, 15 },
                Target = 9
            };
            var expected = new[] { 0, 2 };
            var problem = new TwoSumProblem();

            var actual = problem.TwoSum(input.Nums, input.Target);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3_Duplicates()
        {
            var input = new Input()
            {
                Nums = new[] { -2, 7, 11, 15, 15, 4 },
                Target = 19
            };
            var expected = new[] { 3, 5 };
            var problem = new TwoSumProblem();

            var actual = problem.TwoSum(input.Nums, input.Target);

            Assert.Equal(expected, actual);
        }

        private class Input
        {
            public int[] Nums { get; set; }

            public int Target { get; set; }
        }
    }
}