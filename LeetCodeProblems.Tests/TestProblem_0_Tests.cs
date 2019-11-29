using LeetCodeProblems.Problems;
using Xunit;

namespace LeetCodeProblems.Tests
{
    public class TestProblem_0_Tests
    {
        [Fact]
        public void Test1()
        {
            var problem = new TestProblem_0();

            var actual = problem.IsTrue(true);
            var expected = true;

            Assert.Equal(expected, actual);
        }
    }
}
