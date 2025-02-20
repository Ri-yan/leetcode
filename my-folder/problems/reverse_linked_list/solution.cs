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
    public ListNode ReverseList(ListNode head) {
        var temp=head;
        Stack<int> s = new Stack<int>();

        while(temp!=null){
            s.Push(temp.val);
            temp=temp.next;
        }
 temp=head;
        while(head!=null){
            head.val=s.Pop();

            head=head.next;
        }
        return temp;
    }
}