using System;
using System.Collections.Generic;

namespace Medium {
    public class AddTwoNumbers {
        //Defined
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode Solution(ListNode l1, ListNode l2) {
            int total = 0;
            List<ListNode> nodes = new List<ListNode>();
            while (l1 != null || l2 != null || total == 1) {
                if (l1 != null) {
                    total += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null) {
                    total += l2.val;
                    l2 = l2.next;
                }
                nodes.Add(new ListNode(total % 10));
                total /= 10;
            }
            int lastIndex = nodes.Count - 1;
            for (int i = 0; i < lastIndex + 1; i++) {
                if (i == lastIndex) {
                    nodes[i].next = null;
                    break;
                }
                nodes[i].next = nodes[i + 1];
            }
            return nodes[0];
        }
    }
}