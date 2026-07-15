/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        

        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode fast = dummy;
        ListNode slow = dummy;

        //move fast n steps
        for(int i = 0; i < n; i++){
            fast = fast.next;
        }

        //move both until fast reaches the end
        while(fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        //remove node
        slow.next = slow.next.next;

        return dummy.next;

    }
}
