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
    public boolean isPalindrome(ListNode head) {
        if(head==null || head.next==null){
            return true;
        }
         ListNode temp=head;
        ListNode temp2=null;
        while(temp!=null){
            temp2= new ListNode(temp.val,temp2);
            temp=temp.next;
        }
        while(head!=null && temp2!=null){
            if(head.val!=temp2.val){
               return false;
            }
            head=head.next;
            temp2=temp2.next;
        }
        return true;
    }
}