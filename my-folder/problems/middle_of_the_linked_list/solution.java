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
    public ListNode middleNode(ListNode head) {
        if(head.next==null ){
            return head;
        }
        if(head.next.next==null){
            return head.next;
        }
        ListNode t = head;
        int count=1;
        while(t.next!=null){
            count++;
            t=t.next;
        }
        int mid=count/2;
        t = head;
        while(mid-1>=0){
             t=t.next;
            mid--;
        }
        return t;
    }
}