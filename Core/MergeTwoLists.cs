using System.Collections.Generic;

namespace Core
{
    public class MergeTwoLists
    {
        public ListNode Go(ListNode l1, ListNode l2)
        {
            return null;
            ListNode result = null;
            ListNode current;
            do
            {
                if (result == null)
                {
                    result = new ListNode(l1.val);
                    if (l2 != null)
                    {
                        current = new ListNode(l2.val);
                        result.next = current;
                    }
                }
                else
                {
                    if(l1 != null)
                    {
                        current = new ListNode(l1.val);
                    }
                }

            } while (l1 != null && l2 != null);
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }

            public List<int> GetFull()
            {
                if (next == null)
                {
                    return new List<int> { val };
                }
                else
                {
                    var z = next.GetFull();
                    z.Insert(0, val);

                    return z;
                }
            }
        }
    }
}