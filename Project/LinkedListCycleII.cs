using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Project
{
    internal static class LinkedListCycleII
    {
        public static ListNode DetectCycle(ListNode head)
        {
            var visitedNodes = new HashSet<ListNode>();
            while (head != null)
            {
                if (visitedNodes.Add(head))
                {
                    head = head.next;
                }
                else
                {
                    return head;
                }
            }
            return null;
        }
    }
}
