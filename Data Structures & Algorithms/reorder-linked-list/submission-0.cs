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
    public void ReorderList(ListNode head) {

        ListNode fast = head;
        ListNode slow = head;

        //find the middle
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        //split second half
        ListNode second = slow.next;
        slow.next = null;


        //reverse list
        ListNode previous = null;
        ListNode current = second;

        while(current != null){

            ListNode next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        second = previous;

        ListNode first = head;

        while(second != null)
        {
            ListNode temp1 = first.next;
            ListNode temp2 = second.next;

            first.next = second;
            second.next = temp1;

            first = temp1;
            second = temp2;
        }
        
    }
}
