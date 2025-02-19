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
    public ListNode MiddleNode(ListNode head) {
        var temp=head;
        int c=0;
        while(temp!=null){
            c++;
            temp=temp.next;
        }
        int mid=(c/2);
        temp=head;
        while(temp!=null){
           
            if(mid==0){
                return temp;
            }
             mid--;
            temp=temp.next;
        }
return null;
    }
}