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
    public ListNode ReverseList(ListNode head) {
        
        if (head?.next == null)
            return head;

        ListNode result = null;

        while(head.next != null) {
           result = new ListNode(head.val, result);
           head = head.next;
        }

        result = new ListNode(head.val, result);


        return result;
    }

}