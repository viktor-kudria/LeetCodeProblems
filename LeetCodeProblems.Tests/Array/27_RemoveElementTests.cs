using LeetCodeProblems.Problems.Array;
using Xunit;

namespace LeetCodeProblems.Tests.Array
{
    public class RemoveElementTests
    {
        [Fact]
        public void Test1()
        {
            var problem = new RemoveElementProblem();

            var input = new Input()
            {
                Nums = new[] {3, 2, 2, 3},
                Val = 3
            };

            var expected = new ExpectedOutput()
            {
                Nums = new[] {2, 2},
                Length = 2
            };

            var actual = problem.RemoveElement(input.Nums, input.Val);

            Assert.Equal(expected.Length, actual);
        }

        [Fact]
        public void Test2()
        {
            var problem = new RemoveElementProblem();

            var input = new Input()
            {
                Nums = new[] { 2 },
                Val = 3
            };

            var expected = new ExpectedOutput()
            {
                Nums = new[] { 2 },
                Length = 1
            };

            var actual = problem.RemoveElement(input.Nums, input.Val);

            Assert.Equal(expected.Length, actual);
        }

        [Fact]
        public void Test3()
        {
            var problem = new RemoveElementProblem();

            var input = new Input()
            {
                Nums = new[] { 2, 2 },
                Val = 2
            };

            var expected = new ExpectedOutput()
            {
                Length = 0
            };

            var actual = problem.RemoveElement(input.Nums, input.Val);

            Assert.Equal(expected.Length, actual);
        }

        private class Input
        {
            public int[] Nums { get; set; }

            public int Val { get; set; }
        }

        private class ExpectedOutput
        {
            public int[] Nums { get; set; }

            public int Length { get; set; }
        }
    }
}