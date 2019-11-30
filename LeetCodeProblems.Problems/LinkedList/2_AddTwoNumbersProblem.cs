namespace LeetCodeProblems.Problems.LinkedList
{
    /// <summary>
    /// 2. Add Two Numbers
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class AddTwoNumbersProblem
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sum;
            int tmp = 0;
            ListNode resultRoot = new ListNode(0);
            ListNode currListNode = resultRoot;

            do
            {
                sum = l1.val + l2.val + tmp;

                if (sum > 9)
                {
                    tmp = 1;
                    currListNode.val = sum - 10;
                }
                else
                {
                    tmp = 0;
                    currListNode.val = sum;
                }

                if (l1.next == null && l2.next == null && tmp == 0)
                {
                    break;
                }

                if (l1.next != null)
                {
                    l1 = l1.next;
                }
                else
                {
                    l1.val = 0;
                }

                if (l2.next != null)
                {
                    l2 = l2.next;
                }
                else
                {
                    l2.val = 0;
                }

                currListNode.next = new ListNode(0);
                currListNode = currListNode.next;
            } while (true);

            return resultRoot;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}