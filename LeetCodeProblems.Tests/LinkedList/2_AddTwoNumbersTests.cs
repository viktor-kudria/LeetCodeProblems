using System.Collections.Generic;
using LeetCodeProblems.Problems.LinkedList;
using Xunit;

namespace LeetCodeProblems.Tests.LinkedList
{
    public class AddTwoNumbersTests
    {
        [Fact]
        public void Test1()
        {
            var problem = new AddTwoNumbersProblem();

            var input1 = CreateList(new[] { 2, 4, 3 });
            var input2 = CreateList(new[] { 5, 6, 4 });

            var expected = CreateList(new[] { 7, 0, 8 });

            var actual = problem.AddTwoNumbers(input1, input2);

            CheckResult(expected, actual);
        }

        [Fact]
        public void Test2_DifferentLength()
        {
            var problem = new AddTwoNumbersProblem();

            var input1 = CreateList(new[] { 2, 4, 3, 1 });
            var input2 = CreateList(new[] { 5, 6, 4 });

            var expected = CreateList(new[] { 7, 0, 8, 1 });

            var actual = problem.AddTwoNumbers(input1, input2);

            CheckResult(expected, actual);
        }

        [Fact]
        public void Test3_DifferentLength()
        {
            var problem = new AddTwoNumbersProblem();

            var input1 = CreateList(new[] { 2, 4, 3 });
            var input2 = CreateList(new[] { 5, 6, 4, 1 });

            var expected = CreateList(new[] { 7, 0, 8, 1 });

            var actual = problem.AddTwoNumbers(input1, input2);

            CheckResult(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            var problem = new AddTwoNumbersProblem();

            var input1 = CreateList(new[] { 9 });
            var input2 = CreateList(new[] { 9 });

            var expected = CreateList(new[] { 8, 1 });

            var actual = problem.AddTwoNumbers(input1, input2);

            CheckResult(expected, actual);
        }

        private ListNode CreateList(int[] arr)
        {
            var rootNode = new ListNode(arr[0]);
            var currentNode = rootNode;

            for (int i = 1; i < arr.Length; i++)
            {
                currentNode.next = new ListNode(arr[i]);
                currentNode = currentNode.next;
            }

            return rootNode;
        }

        private void CheckResult(ListNode expected, ListNode actual)
        {
            do
            {
                Assert.Equal(expected.val, actual.val);
                if (expected.next != null || actual.next != null)
                {
                    expected = expected.next;
                    actual = actual.next;

                    continue;
                }

                return;
            } while (true);
        }
    }
}