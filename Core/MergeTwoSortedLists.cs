namespace Core.MergeTwoSortedLists
{
    using System;

    //* Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            if (next != null)
            {
                return $"{val},{next?.ToString()}";
            }
            else
            {
                return val.ToString();
            }

        }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode lastNode = null;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    if (result == null)
                    {
                        result = new ListNode(l1.val);
                        lastNode = result;
                    }
                    else
                    {
                        lastNode.next = new ListNode(l1.val);
                        lastNode = lastNode.next;
                    }
                    l1 = l1.next;
                }
                else if (l2.val < l1.val)
                {
                    if (result == null)
                    {
                        result = new ListNode(l2.val);
                        lastNode = result;
                    }
                    else
                    {
                        lastNode.next = new ListNode(l2.val);
                        lastNode = lastNode.next;
                    }
                    l2 = l2.next;
                }
                else
                {
                    if (result == null)
                    {
                        result = new ListNode(l1.val, new ListNode(l2.val));
                        lastNode = result.next;
                    }
                    else
                    {
                        lastNode.next = new ListNode(l1.val, new ListNode(l2.val));
                        lastNode = lastNode.next.next;
                    }
                    l1 = l1.next;
                    l2 = l2.next;
                }
            }

            var c = l1 ?? l2;
            while (c != null)
            {
                if (lastNode != null)
                {
                    lastNode.next = new ListNode(c.val);
                    lastNode = lastNode.next;
                }
                else
                {
                    result = new ListNode(c.val);
                    lastNode = result;
                }
                c = c.next;
            }

            return result;

        }
    }
}