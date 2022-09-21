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
    public ListNode rotateRight(ListNode head, int k) {
        if(head==null || head.next==null){
            return head;
        }
        int c=1;
        ListNode tail=head;
        while(tail.next!=null){
            c++;
            tail=tail.next;
        }
        k=k%c;
        if(k==0)
            return head;
        int t2=c-k-1;
         ListNode tail2=head;
        
       while(t2>0){
           tail2=tail2.next;
           t2--;
       }
        ListNode head2=tail2.next;
        tail2.next=null;
        tail.next=head;
        head=head2;
        return head;
    }
}