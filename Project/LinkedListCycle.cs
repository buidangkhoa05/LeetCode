using System.Runtime.InteropServices;

namespace Project
{
    // url : https://leetcode.com/problems/linked-list-cycle/
    public static class LinkedListCycle
    {
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;

            var visitedDict = new HashSet<ListNode>();

            while (head.next != null)
            {
                visitedDict.Add(head);

                if (visitedDict.Contains(head.next))
                    return true;

                head = head.next;
            }

            return false;
        }
    }

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}




