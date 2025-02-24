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
        var slow=head;
        var fast=head;
        while(n>0){
            fast=fast.next;
            n--;
        }
        if(fast==null) return head.next;
        while(fast!=null && fast.next !=null){

            slow=slow.next;
            fast=fast.next;
        }
        if(slow!=null && slow.next!=null) slow.next = slow.next.next;

        return head;
    }
}