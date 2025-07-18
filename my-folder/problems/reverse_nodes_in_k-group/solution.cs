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
   private ListNode reverse(ListNode head) {
        ListNode prev = null, curr = head;
        while (curr != null) {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }
    public static ListNode FindKthNode(ListNode head,int k){
        var curr=head;
        while (curr != null && k > 1) {
            curr = curr.next;
            k--;
        }
       return curr;
    }
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null || k <= 1) return head;
        var temp=head;
        ListNode prev=null;
        while(temp!=null){
           var kth = FindKthNode(temp, k);
            if(kth==null) {
               if(prev!=null) prev.next=temp;
                break; 
            } 
            var next = kth.next;
            kth.next=null;
            var nn = reverse(temp);
            if(temp==head) head=kth;
            else  prev.next=nn;
        prev = temp;      
        temp = next;
        }
       return head;
    }
}