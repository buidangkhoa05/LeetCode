

using System.Runtime.InteropServices;

namespace Project
{
    // url : https://leetcode.com/problems/intersection-of-two-linked-lists/
    public static class IntersectionofTwoLinkedLists
    {
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            // first resolve 
            // if (headA == null || headB == null)
            //     return null;

            // var hashMap = new HashSet<ListNode>();

            // while (headA != null || headB != null)
            // {
            //     if (headA != null && !hashMap.Add(headA))
            //         return headA;

            //     if (headB != null && !hashMap.Add(headB))
            //         return headB;

            //     headA = headA?.next;
            //     headB = headB?.next;
            // }

            // return null;

            // second resolve 
            var firstSub = headA;
            var secondSub = headB;

            while(firstSub != secondSub)
            {
                firstSub = firstSub == null ? headB : firstSub.next;
                secondSub = secondSub == null ? headA : secondSub.next;
            }

            return firstSub; //or secondSub is also right 
        }
    }
}