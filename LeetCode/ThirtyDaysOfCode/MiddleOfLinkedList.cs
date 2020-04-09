using System;
using System.Collections.Generic;

namespace LeetCode.ThirtyDaysOfCode
{
    public class MiddleOfLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            var fast = head;
            while (fast != null && fast.next != null) {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
    }
}