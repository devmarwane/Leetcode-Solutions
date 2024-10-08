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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // Create a dummy node to simplify list creation
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;  // Pointer to construct the new list

        while (list1 != null || list2 != null) {
            if (list1 == null || list2?.val <= list1.val) {
                // Add the rest of list2
                current.next = new ListNode(list2.val);
                list2 = list2.next;
            } 
            else if (list2 == null || list2.val > list1.val) {
                // Add the rest of list1
                current.next = new ListNode(list1.val);
                list1 = list1.next;
            } 
 
            // Move the pointer forward to the newly added node
            current = current.next;
        }

        // Return the merged list, skipping the dummy node
        return dummy.next;
    }
}
