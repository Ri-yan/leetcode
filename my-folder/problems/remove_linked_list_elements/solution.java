/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode removeElements(ListNode head, int val) {
        if(head==null){
            return head;
        }
        if(head.val==val && head.next==null){
            head=null;
            return head;
        }
        if(head.val==val && head.next!=null){
            head=head.next;
        }
        ListNode prev = null;
        ListNode curr = head;
        while(curr!=null){
            if(curr.val==val){
                if(prev!=null){
                    prev.next=curr.next;
                }
                else{
                    head=head.next;
                }
            }else{
                prev=curr;
            }
            curr=curr.next;
        }
        return head;
    }
}