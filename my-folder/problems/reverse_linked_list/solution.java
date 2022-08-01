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
    public ListNode reverseList(ListNode head) {
        if(head==null || head.next==null){
            return head;
        }
        ListNode temp2 = null;
        while(head!=null){
            ListNode newNode=new ListNode(head.val,temp2);
            temp2=newNode;
            head=head.next;
        }
        head=temp2;
        return head;
    }
}