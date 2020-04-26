using LeetCodeProblems.Problems.Array;
using Xunit;

namespace LeetCodeProblems.Tests.Array
{
    public class MaximumSubarrayTests
    {
        [Fact]
        public void Test1()
        {
            var problem = new MaximumSubarrayProblem();
            var input = new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
            var expected = 6;

            var actual = problem.MaxSubArray(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            var problem = new MaximumSubarrayProblem();
            var input = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            var expected = 9;

            var actual = problem.MaxSubArray(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            var problem = new MaximumSubarrayProblem();
            var input = new[] { -1, 10, -10 };
            var expected = 10;

            var actual = problem.MaxSubArray(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            var problem = new MaximumSubarrayProblem();
            var input = new[] { -84, -87, -78, -16, -94, -36, -87, -93, -50, -22,
                -63, -28, -91, -60, -64, -27, -41, -27, -73, -37, -12, -69, -68,
                -30, -83, -31, -63, -24, -68, -36, -30, -3, -23, -59, -70, -68, -94,
                -57, -12, -43, -30, -74, -22, -20, -85, -38, -99, -25, -16, -71, -14, -27, -92,
                -81, -57, -74, -63, -71, -97, -82, -6, -26, -85, -28, -37, -6, -47, -30, -14, -58,
                -25, -96, -83, -46, -15, -68, -35, -65, -44, -51, -88, -9, -77, -79, -89, -85,
                -4, -52, -55, -100, -33, -61, -77, -69, -40, -13, -27, -87, -95, -40 };

            var expected = -3;

            var actual = problem.MaxSubArray(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test5()
        {
            var problem = new MaximumSubarrayProblem();
            var input = new[] { 1, 2, -1, -2, 2, 1, -2, 1, 4, -5, 4 };

            var expected = 6;

            var actual = problem.MaxSubArray(input);

            Assert.Equal(expected, actual);
        }
    }
}