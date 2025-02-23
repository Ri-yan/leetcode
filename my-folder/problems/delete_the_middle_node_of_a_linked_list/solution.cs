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
    public ListNode DeleteMiddle(ListNode head) {
        var slow=head;
        var fast=head;
        if (head == null || head.next == null) {
            return null;
        }
                fast = head.next.next;

        while(fast!=null && fast.next !=null){
            slow=slow.next;
            fast=fast.next.next;
        }
        if (slow.next != null) {
            slow.next = slow.next.next;
        }
        return head;
    }
}