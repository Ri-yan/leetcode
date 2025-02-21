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
    public bool IsPalindrome(ListNode head) {
        Stack<int> s = new Stack<int>();
        var temp = head;
        while(temp!=null){
            s.Push(temp.val);
            temp=temp.next;
        }
        temp=head;
        while(temp!=null){
            if(s.Peek()==temp.val) s.Pop(); //2,1
            else return false;
             temp=temp.next;
        }
        return true;
    }
}