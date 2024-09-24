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
  public bool IsPalindrome(ListNode head)
    {

        List<int> list = new List<int>();
        do
        {
            list.Add(head.val);
            head = head?.next;
        }while(head != null);

        if (list.Count()==1)
            return true;

        int[] arr1;
        int[] arr2;
        arr1 = list.Take((list.Count / 2) + (list.Count % 2)).ToArray();
        arr2 = list.Skip((list.Count / 2)).Reverse().ToArray();

        return arr1.SequenceEqual(arr2);

    }
}