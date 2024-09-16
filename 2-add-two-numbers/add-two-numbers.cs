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
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
 {
     int additional = 0;

     ListNode head = null;
     ListNode current = null;

     while (l1?.val != null || l2?.val != null)
     {
         int sum = (l1?.val??0) + (l2?.val??0) + additional;
         if (sum >= 10)
         {
             additional = sum / 10;
             sum = sum % 10;
         }
         else
         {
             additional = 0;
         }

         if (head == null)
         {
             head = new ListNode(sum);
             current = head;
         }
         else
         {
             current.next = new ListNode(sum);
             current = current.next;
         }

         l1 = l1?.next;
         l2 = l2?.next;
     }

     if (additional>0)
     {
         var digits = ConvertToDigits(additional);
         foreach(var digit in digits)
         {
             current.next = new ListNode(digit);
             current = current.next;
         }
     }

     return head;
 }

 List<int> ConvertToDigits(int number)
 {
     List<int> digits = new List<int>();

     while (number > 0)
     {
         digits.Add(number % 10);
         number /= 10;
     }

     digits.Reverse();

     return digits;
 }
}