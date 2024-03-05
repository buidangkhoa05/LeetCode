namespace _net_version.Project
{
    internal static class AddTwoNumber
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var tmp = 0;
            var headNode = l1;

            while (l1 != null || l2 != null)
            {
                l1 ??= new ListNode(0);
                l2 ??= new ListNode(0);

                tmp += l1.val + l2.val;

                if (tmp >= 10)
                {
                    l1.val = tmp % 10;
                    tmp = 1;
                }
                else
                {
                    l1.val = tmp;
                    tmp = 0;
                }

                if ((tmp != 0 && l1.next == null) 
                    || (l1.next == null && l2.next != null))
                {
                    l1.next = new ListNode(0);
                }

                l1 = l1.next;
                l2 = l2.next;
            }    

            return headNode;
        }
    }
}
