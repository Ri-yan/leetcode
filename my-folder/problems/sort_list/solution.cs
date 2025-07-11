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
    public static ListNode findMid(ListNode node){
        if (node == null) return null;

        var slow=node;
        var fast=node.next;
        while(fast!=null && fast.next!=null){
            fast=fast.next.next;
            slow=slow.next;
        }
        return slow;
    }
    public ListNode Merge(ListNode left,ListNode right) {
        var dummy=new ListNode(-1);
        var curr = dummy;
        while( left!=null && right !=null){
            if(left.val<right.val){
                curr.next=left;
                left=left.next;
            }else{
                curr.next=right;
                right=right.next;
            }
            curr=curr.next;
        }
        if(left != null) curr.next = left;
        if(right != null) curr.next = right;
        return dummy.next;
    }
    public ListNode SortList(ListNode head) {
        if(head == null || head.next == null) return head;

        var mid = findMid(head);
        var left = head;
        var right = mid.next;
        mid.next = null;
    
        left = SortList(left);
        right = SortList(right);
    
        return Merge(left, right);
    }
}