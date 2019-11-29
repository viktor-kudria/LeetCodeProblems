using LeetCodeProblems.Problems.Array;
using Xunit;

namespace LeetCodeProblems.Tests.Array
{
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [Fact]
        public void Test1()
        {
            var input = new Input()
            {
                Nums = new[] { 1, 1, 2 }
            };
            var problem = new RemoveDuplicatesFromSortedArrayProblem();

            var actual = problem.RemoveDuplicates(input.Nums);

            var expected = new ExpectedOutput()
            {
                Length = 2,
                Nums = new[] { 1, 2 }
            };

            CheckResult(expected, actual, input);
        }

        [Fact]
        public void Test2()
        {
            var input = new Input()
            {
                Nums = new[] { 1 }
            };
            var problem = new RemoveDuplicatesFromSortedArrayProblem();

            var actual = problem.RemoveDuplicates(input.Nums);

            var expected = new ExpectedOutput()
            {
                Length = 1,
                Nums = new[] { 1 }
            };

            CheckResult(expected, actual, input);
        }

        [Fact]
        public void Test3()
        {
            var input = new Input()
            {
                Nums = new[] { 1, 1, 1, 1 }
            };
            var problem = new RemoveDuplicatesFromSortedArrayProblem();

            var actual = problem.RemoveDuplicates(input.Nums);

            var expected = new ExpectedOutput()
            {
                Length = 1,
                Nums = new[] { 1, 1, 1, 1 }
            };

            CheckResult(expected, actual, input);
        }

        [Fact]
        public void Test4()
        {
            var input = new Input()
            {
                Nums = new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5 }
            };
            var problem = new RemoveDuplicatesFromSortedArrayProblem();

            var actual = problem.RemoveDuplicates(input.Nums);

            var expected = new ExpectedOutput()
            {
                Length = 5,
                Nums = new[] { 1, 2, 3, 4, 5 }
            };

            CheckResult(expected, actual, input);
        }

        [Fact]
        public void Test5()
        {
            var input = new Input()
            {
                Nums = new[] { 1, 2 }
            };
            var problem = new RemoveDuplicatesFromSortedArrayProblem();

            var actual = problem.RemoveDuplicates(input.Nums);

            var expected = new ExpectedOutput()
            {
                Length = 2,
                Nums = new[] { 1, 2 }
            };

            CheckResult(expected, actual, input);
        }

        private void CheckResult(ExpectedOutput expected, int actual, Input input)
        {
            Assert.Equal(expected.Length, actual);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected.Nums[i], input.Nums[i]);
            }
        }

        private class Input
        {
            public int[] Nums { get; set; }
        }

        private class ExpectedOutput
        {
            public int[] Nums { get; set; }

            public int Length { get; set; }
        }
    }
}