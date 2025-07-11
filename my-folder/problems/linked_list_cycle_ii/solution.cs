/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if(head==null){
            return head;
        }
        var slow=head;
        var fast=head;

        while(fast!=null && fast.next!=null){
            slow=slow.next;
            fast=fast.next.next;
            if(fast==slow){
                slow=head;
                while (slow != fast) {
                    slow = slow.next;  
                    fast = fast.next;  
                }
                return slow;
            };
           
        }
        return null;
    }
}