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
    public ListNode Rev(ListNode head) {
        var temp = head;
        ListNode prev=null;
        while(temp!=null){
            var next = temp.next;
            temp.next=prev;
            prev=temp;
            temp=next;
        }
        return prev;
    }
    public ListNode RotateRight(ListNode head, int k) {
        if(head==null ||head.next==null) return head;
        var fast=head;
        var slow=head;
        int length=0;
        while(fast !=null ){
            length++;
            fast=fast.next;
        }
     k = k % length;
    if (k == 0) return head;

       int cut = length - k;

for (int i = 1; i < cut; i++) {
    slow = slow.next;
}

        var h1 = head;
        var h2 = slow.next;
        slow.next=null;
         h1 = Rev(h1);
         h2 = Rev(h2);
        var g =h1;
        while(g.next!=null){
            g=g.next;
        }
        g.next=h2;

        return Rev(h1);
        
    }
}